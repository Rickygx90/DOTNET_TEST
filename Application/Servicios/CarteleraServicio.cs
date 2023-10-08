using System;
using System.Collections.Generic;
using System.Text;

using Domain;
using Domain.Interfaces.Repositorios;
using Application.Interfaces;
using Domain.Entidades;

namespace Application.Servicios
{
  public class CarteleraServicio : IServicioCartelera<BillboardEntity>
  {
    private readonly IRepositorioCartelera<BillboardEntity> repoCartelera;

    public CarteleraServicio(IRepositorioCartelera<BillboardEntity> _repoCartelera)
    {
      repoCartelera = _repoCartelera;
    }

    public List<BillboardEntity> IListarDisponibilidadCartelera()
    {
      return repoCartelera.IListarDisponibilidadCartelera();
    }
  }
}