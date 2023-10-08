using System;
using System.Collections.Generic;
using System.Text;

using Domain;
using Domain.Interfaces.Repositorios;
using Application.Interfaces;
using Domain.Entidades;

namespace Application.Servicios
{
  public class BookingServicio : IServicioBase<BookingEntity, DateTime>
  {
    private readonly IRepositorioBase<BookingEntity, DateTime> repoBooking;

    public BookingServicio(IRepositorioBase<BookingEntity, DateTime> _repoBooking)
    {
      repoBooking = _repoBooking;
    }

    public List<BookingEntity> Listar(DateTime entidadFechaInicio, DateTime entidadFechaFin)
    {
      return repoBooking.Listar(entidadFechaInicio, entidadFechaFin);
    }
  }
}