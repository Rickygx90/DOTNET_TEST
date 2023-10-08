using Domain.Interfaces.Repositorios;
using Infrastructure.Contextos;
using Domain.Entidades;

namespace Infrastructure.Repositorios
{
  public class ButacaRepo : IRepositorioButaca<SeatEntity>
  {
    private CineContexto db;

    public ButacaRepo(CineContexto _db)
    {
      db = _db;
    }

    public List<SeatEntity> ListarButacas()
    {
      return db.SeatEntities.ToList();
    }
  }
}