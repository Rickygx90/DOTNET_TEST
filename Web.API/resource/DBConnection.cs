using MySqlConnector;

namespace Web.API.resource;
public class DBConnection
{

  public MySqlConnection GetConnection()
  {
    return new MySqlConnection(Environment.GetEnvironmentVariable("MySqlDataBase"));
  }
}
