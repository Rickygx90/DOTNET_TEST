namespace Domain.Interfaces
{
    public interface IListarReservasTerror<TEntidad, TEntidadFecha>
  {
    List<TEntidad> Listar(TEntidadFecha entidadFechaInicio, TEntidadFecha entidadFechaFin);
  }
}