using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocalitiesManager.Data.Entities;

public class LocalityType : EntityBase
{
    public long Id { get; set; }

    [Required]
    [StringLength(100)]
    [Column(TypeName = "VARCHAR")]
    public string Name { get; set; }

    [Required]
    [StringLength(100)]
    [Column(TypeName = "VARCHAR")]
    public string Prefix { get; set; }

    public virtual List<Locality> Localities { get; set; }
}