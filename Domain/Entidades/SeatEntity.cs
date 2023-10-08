using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Common;

namespace Domain.Entidades
{
    public class SeatEntity : BaseEntity
  {
    [Required]
    public short Number { get; set; }

    [Required]
    public short RowNumber { get; set; }

    [ForeignKey("Room")]
    public int RoomId { get; set; }
    public required RoomEntity Room { get; set; }
  }
}