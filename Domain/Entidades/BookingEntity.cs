using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Common;

namespace Domain.Entidades
{

  public class BookingEntity : BaseEntity
  {
    [Required]
    public DateTime Date { get; set; }

    [ForeignKey("Customer")]
    public int CustomerId { get; set; }
    public required CustomerEntity Customer { get; set; }

    [ForeignKey("Seat")]
    public int SeatId { get; set; }
    public required SeatEntity Seat { get; set; }

    [ForeignKey("Billboard")]
    public int BillboardId { get; set; }
    public required BillboardEntity Billboard { get; set; }
  }
}