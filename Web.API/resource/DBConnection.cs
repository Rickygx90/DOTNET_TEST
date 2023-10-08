using MySqlConnector;

namespace Web.API.resource;
public class DBConnection
{

  public MySqlConnection GetConnection()
  {
    return new MySqlConnection("server=localhost,3306;database=cine;uid=root;");
  }
}
