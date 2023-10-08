using System;
using System.Collections.Generic;
using System.Text;

using Domain.Interfaces;

namespace Domain.Interfaces.Repositorios
{
  public interface IRepositorioButaca<TEntidad>
    : IListarButacas<TEntidad>
  {
  }
}