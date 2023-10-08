using Microsoft.AspNetCore.Mvc;
using System.Transactions;
using MySqlConnector;
using Web.API.resource;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web.API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CancelarReservaButacaController : ControllerBase
  {
    private object? idBooking;
    private object? idSeat;
    private object? statusBooking;
    private string? message;

    // GET: api/CancelarReservaButaca
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
      try
      {
        DBConnection _dbConnection = new DBConnection();
        var connection = _dbConnection.GetConnection();

        using (TransactionScope scope = new TransactionScope())
        {
          connection.Open();
          var findBooking = new MySqlCommand("SELECT * FROM BookingEntities WHERE Id = " + id + ";", connection);
          var read = findBooking.ExecuteReader();
          while (read.Read())
          {
            idBooking = read.GetValue(0);
            idSeat = read.GetValue(3);
            statusBooking = read.GetValue(5);
          }
          read.Close();

          if (idBooking is null)
          {
            message = "No existe una reserva (booking) con el ID: " + id + "....";
          }
          else
          {
            if ((bool)statusBooking)
            {
              var updateBooking = new MySqlCommand("UPDATE BookingEntities SET Status = 0 WHERE Id = " + id + ";", connection);
              updateBooking.ExecuteNonQuery();
              var updateSeat = new MySqlCommand("UPDATE SeatEntities SET Status = 0 WHERE Id = " + idSeat + ";", connection);
              updateSeat.ExecuteNonQuery();
              message = "La reserva con ID: " + id + " y su butaca (" + idSeat + ") a sido cancelada exitosamente!!!";
            }
            else
            {
              message = "La reserva con ID: " + id + " ya se encuentra cancelada...";
            }
          }
          scope.Complete();
        }
        connection.Close();
        return message;
      }
      catch (Exception ex)
      {
        Console.WriteLine("Error: {0}", ex.Message);
        return "Error: " + ex.Message;
      }
    }
  }
}
