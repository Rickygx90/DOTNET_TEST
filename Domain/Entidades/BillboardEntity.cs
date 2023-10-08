using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Common;

namespace Domain.Entidades
{

  public class BillboardEntity : BaseEntity
  {
    [Required]
    public DateTime Date { get; set; }

    [Required]
    public TimeSpan StartTime { get; set; }

    [Required]
    public TimeSpan EndTime { get; set; }

    [ForeignKey("Movie")]
    public int MovieId { get; set; }
    public required MovieEntity Movie { get; set; }

    [ForeignKey("Room")]
    public int RoomId { get; set; }
    public required RoomEntity Room { get; set; }
  }
}