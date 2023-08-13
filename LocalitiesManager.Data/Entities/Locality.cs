using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocalitiesManager.Data.Entities;

public class Locality : EntityBase
{
    public long Id { get; set; }

    [Required]
    [StringLength(100)]
    [Column(TypeName = "VARCHAR")]
    public string Name { get; set; }

    [Required]
    public long LocalityTypeId { get; set; }

    public virtual LocalityType LocalityType { get; set; }

    public virtual List<Street> Streets { get; set; }
}