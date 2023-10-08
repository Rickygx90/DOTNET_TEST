using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Domain;
using Application.Servicios;
using Infrastructure.Contextos;
using Infrastructure.Repositorios;
using Domain.Entidades;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web.API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ButacaController : ControllerBase
  {

    ButacaServicio CrearServicio()
    {
      CineContexto db = new CineContexto();
      ButacaRepo repo = new ButacaRepo(db);
      ButacaServicio servicio = new ButacaServicio(repo);
      return servicio;
    }
    // GET: api/Butaca
    [HttpGet]
    public ActionResult<List<SeatEntity>> Get()
    {
      var servicio = CrearServicio();
      return Ok(servicio.ListarButacas());
    }
  }
}