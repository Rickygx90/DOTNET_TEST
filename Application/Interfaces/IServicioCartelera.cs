using System;
using System.Collections.Generic;
using System.Text;

using Domain.Interfaces;

namespace Application.Interfaces
{
  interface IServicioCartelera<TEntidad>
    : IListarCartelera<TEntidad>
  {
  }
}