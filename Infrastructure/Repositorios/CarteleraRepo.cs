using Domain.Interfaces.Repositorios;
using Infrastructure.Contextos;
using Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositorios
{
  public class CarteleraRepo : IRepositorioCartelera<BillboardEntity>
  {
    private CineContexto db;

    public CarteleraRepo(CineContexto _db)
    {
      db = _db;
    }

    public List<BillboardEntity> IListarDisponibilidadCartelera()
    {
      DateTime date = DateTime.Now.Date;
      var lista = db.BillboardEntities.Where(c => c.Date.Date == date).Include(b => b.Room).ToList();
      Console.WriteLine(lista);
      return lista;
    }
  }
}