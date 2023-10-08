using Microsoft.AspNetCore.Mvc;
using Application.Servicios;
using Infrastructure.Contextos;
using Infrastructure.Repositorios;
using Domain.Entidades;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web.API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class BookingTHRILLERController : ControllerBase
  {

    BookingServicio CrearServicio()
    {
      CineContexto db = new CineContexto();
      BookingRepo repo = new BookingRepo(db);
      BookingServicio servicio = new BookingServicio(repo);
      return servicio;
    }
    // GET: api/BookingTHRILLER
    [HttpGet]
    public ActionResult<List<BookingEntity>> Get(DateTime fechaInicio, DateTime fechaFin)
    {
      var servicio = CrearServicio();
      return Ok(servicio.Listar(fechaInicio, fechaFin));
    }
  }
}