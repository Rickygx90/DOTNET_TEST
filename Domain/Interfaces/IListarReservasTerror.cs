using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
  public interface IListarReservasTerror<TEntidad, TEntidadFecha>
  {
    List<TEntidad> Listar(TEntidadFecha entidadFechaInicio, TEntidadFecha entidadFechaFin);
  }
}