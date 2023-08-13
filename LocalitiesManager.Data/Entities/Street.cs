using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocalitiesManager.Data.Entities;

public class Street : EntityBase
{
    public long Id { get; set; }

    [Required]
    [StringLength(100)]
    [Column(TypeName = "VARCHAR")]
    public string Name { get; set; }

    [Required]
    public long StreetTypeId { get; set; }

    [Required]
    public long LocalityId { get; set; }

    public virtual StreetType StreetType { get; set; }
    public virtual Locality Locality { get; set; }
    
    public virtual List<House> Houses { get; set; }
}