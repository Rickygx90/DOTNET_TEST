using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Common;

namespace Domain.Entidades
{
  public enum MovieGenreEnum { ACTION, ADVENTURE, COMEDY, DRAMA, FANTASY, HORROR, MUSICALS, MYSTERY, ROMANCE, SCIENCE_FICTION, SPORTS, THRILLER, WESTERN }

  public class MovieEntity : BaseEntity
  {
    [Required]
    [MaxLength(100)]
    public required string Name { get; set; }

    [Required]
    public MovieGenreEnum Genre { get; set; }

    [Required]
    public short AllowedAge { get; set; }

    [Required]
    public short LengthMinutes { get; set; }
  }
}