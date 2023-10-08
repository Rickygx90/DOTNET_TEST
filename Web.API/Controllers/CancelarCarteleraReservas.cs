using Microsoft.AspNetCore.Mvc;
using System.Transactions;
using MySqlConnector;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web.API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CancelarCarteleraReservas : ControllerBase
  {
    private object? roomId;
    private object? dateBillboard;

    // GET: api/CancelarCarteleraReservas
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
      try
      {
        DateTime date = DateTime.Now.Date;
        var connection = new MySqlConnection(Environment.GetEnvironmentVariable("MySqlDataBase"));
        using (TransactionScope scope = new TransactionScope())
        {
          connection.Open();

          var getRoomId = new MySqlCommand("SELECT RoomId, Date FROM BillboardEntities WHERE Id = " + id + ";", connection);
          var readGetRoomId = getRoomId.ExecuteReader();
          while (readGetRoomId.Read())
          {
            roomId = readGetRoomId.GetValue(0);
            dateBillboard = readGetRoomId.GetValue(1);
          }
          readGetRoomId.Close();
          if (Convert.ToDateTime(dateBillboard).Date < date)
          {
            throw new CustomException("No se puede cancelar funciones de la cartelera con fecha anterior a la actual");
          }

          var updateBillaboard = new MySqlCommand("UPDATE BillboardEntities SET Status = 0 WHERE Id = " + id + ";", connection);
          updateBillaboard.ExecuteNonQuery();

          var updateBookings = new MySqlCommand("UPDATE BookingEntities SET Status = 0 WHERE BillboardId = " + id + ";", connection);
          updateBookings.ExecuteNonQuery();

          var updateSeat = new MySqlCommand("UPDATE SeatEntities SET Status = 1 WHERE RoomId = " + roomId + ";", connection);
          updateSeat.ExecuteNonQuery();

          var getCustomerId = new MySqlCommand("SELECT CustomerId FROM BookingEntities WHERE BillboardId = " + id + ";", connection);
          var readGetCustomerId = getCustomerId.ExecuteReader();
          var lst = new List<object>();
          while (readGetCustomerId.Read())
            lst.Add(readGetCustomerId.GetValue(0));

          readGetCustomerId.Close();
          var newList = lst.ToArray();

          Console.WriteLine("Los clientes afectados fueron: ");
          for (int i = 0; i < newList.Length; i++)
          {
            var getCustomer = new MySqlCommand("SELECT * FROM CustomerEntities WHERE Id = " + newList[i] + ";", connection);
            var readGetCustomer = getCustomer.ExecuteReader();
            while (readGetCustomer.Read())
              Console.WriteLine("Id: " + readGetCustomer.GetValue(0) + ", Nombres: " + readGetCustomer.GetValue(2) + readGetCustomer.GetValue(3));
            readGetCustomer.Close();
          }
          scope.Complete();
        }
        connection.Close();
        return "Se cancelo la cartelera con ID: " + id + " y las reservas asociadas a ella, se habilitaron las butacas pertenecientes a la sala con ID: " + roomId;
      }
      catch (Exception ex)
      {
        Console.WriteLine("Error: {0}", ex.Message);
        return "Error: " + ex.Message;
      }
    }
  }
}

