using System;
using System.Collections.Generic;
using System.Text;

using Domain.Interfaces;

namespace Application.Interfaces
{
  interface IServicioBase<TEntidad, TEntidadFecha>
    : IListarReservasTerror<TEntidad, TEntidadFecha>
  {
  }
}