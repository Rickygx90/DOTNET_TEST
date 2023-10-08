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
  public class DisponibilidadCarteleraHoyController : ControllerBase
  {

    CarteleraServicio CrearServicio()
    {
      CineContexto db = new CineContexto();
      CarteleraRepo repo = new CarteleraRepo(db);
      CarteleraServicio servicio = new CarteleraServicio(repo);
      return servicio;
    }
    // GET: api/Cartelera
    [HttpGet]
    public ActionResult<List<BillboardEntity>> Get()
    {
      var servicio = CrearServicio();
      return Ok(servicio.IListarDisponibilidadCartelera());
    }
  }
}