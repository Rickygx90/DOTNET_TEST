using System;
using System.Collections.Generic;
using System.Text;

using Domain.Interfaces;

namespace Domain.Interfaces.Repositorios
{
  public interface IRepositorioBase<TEntidad, TEntidadFecha>
    : IListarReservasTerror<TEntidad, TEntidadFecha>
  {
  }
}