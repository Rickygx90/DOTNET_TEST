
namespace Web.API.Controllers
{
  public class CustomException : Exception
  {
    public CustomException(string message) : base(String.Format(message))
    {

    }
  }
}