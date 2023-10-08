using System.ComponentModel.DataAnnotations;
using Domain.Common;

namespace Domain.Entidades
{

    public class RoomEntity : BaseEntity
  {
    [Required]
    [MaxLength(50)]
    public required string Name { get; set; }

    [Required]
    public short Number { get; set; }

    [Required]
    public short Available { get; set; }

    [Required]
    public short Unavailable { get; set; }
  }
}