using Microsoft.EntityFrameworkCore;
using Domain.Entidades;

namespace Infrastructure.Contextos
{
  public class CineContexto : DbContext
  {
    public CineContexto(){
      Database.SetCommandTimeout(150000);
    }
    public DbSet<BookingEntity> BookingEntities { get; set; }
    public DbSet<BillboardEntity> BillboardEntities { get; set; }
    public DbSet<CustomerEntity> CustomerEntities { get; set; }
    public DbSet<MovieEntity> MovieEntities { get; set; }
    public DbSet<RoomEntity> RoomEntities { get; set; }
    public DbSet<SeatEntity> SeatEntities { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
      var connectionString = "server=localhost,3306;database=cine;uid=root;connect timeout=900;";
    
      options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }
  }
}