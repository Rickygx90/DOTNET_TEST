using NUnit.Framework;
using Web.API.resource;
using MySqlConnector;

namespace Web.API.Test;

[TestFixture]
public class CancelarReservaButacaTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        DBConnection _dbConnection = new DBConnection();
        var connection = _dbConnection.GetConnection();
        Console.WriteLine("Verifica si el objeto de conexion no es null...");
        Assert.NotNull(connection);
    }
}