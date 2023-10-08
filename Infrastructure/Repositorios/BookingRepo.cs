using Domain.Interfaces.Repositorios;
using Infrastructure.Contextos;
using Domain.Entidades;

namespace Infrastructure.Repositorios
{
  public class BookingRepo : IRepositorioBase<BookingEntity, DateTime>
  {
    private CineContexto db;

    public BookingRepo(CineContexto _db)
    {
      db = _db;
    }

    public List<BookingEntity> Listar(DateTime entidadFechaInicio, DateTime entidadFechaFin)
    {
      var lista = db.BookingEntities.Where(c => c.Billboard.Date > entidadFechaInicio && c.Billboard.Date < entidadFechaFin && c.Billboard.Movie.Genre == MovieGenreEnum.THRILLER).ToList();
      return lista;

    }
  }
}