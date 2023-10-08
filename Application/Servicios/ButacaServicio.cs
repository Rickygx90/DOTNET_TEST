using System;
using System.Collections.Generic;
using System.Text;

using Domain;
using Domain.Interfaces.Repositorios;
using Application.Interfaces;
using Domain.Entidades;

namespace Application.Servicios
{
  public class ButacaServicio : IServicioButaca<SeatEntity>
  {
    private readonly IRepositorioButaca<SeatEntity> repoButaca;

    public ButacaServicio(IRepositorioButaca<SeatEntity> _repoButaca)
    {
      repoButaca = _repoButaca;
    }

    public List<SeatEntity> ListarButacas()
    {
      return repoButaca.ListarButacas();
    }
  }
}