using System;
using System.Collections.Generic;
using System.Text;

using Domain.Interfaces;

namespace Domain.Interfaces.Repositorios
{
  public interface IRepositorioCartelera<TEntidad>
    : IListarCartelera<TEntidad>
  {
  }
}