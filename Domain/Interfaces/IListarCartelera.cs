using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
  public interface IListarCartelera<TEntidad>
  {
    List<TEntidad> IListarDisponibilidadCartelera();
  }
}