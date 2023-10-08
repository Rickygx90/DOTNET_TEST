using System.ComponentModel.DataAnnotations;
using Domain.Common;

namespace Domain.Entidades
{
    public class CustomerEntity : BaseEntity
  {
    [Required]
    [MaxLength(20)]
    //[Index(IsUnique = true)]
    public required string DocumentNumber { get; set; }

    [Required]
    [MaxLength(30)]
    public required string Name { get; set; }

    [Required]
    [MaxLength(30)]
    public required string Lastname { get; set; }

    [Required]
    public short Age { get; set; }

    [MaxLength(20)]
    public required string PhoneNumber { get; set; }

    [MaxLength(100)]
    public required string Email { get; set; }
  }
}