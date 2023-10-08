using System;
using System.Collections.Generic;
using System.Text;

using Domain.Interfaces;

namespace Application.Interfaces
{
  interface IServicioButaca<TEntidad>
    : IListarButacas<TEntidad>
  {
  }
}