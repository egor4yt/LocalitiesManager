using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocalitiesManager.Data.Entities;

public class Apartment : EntityBase
{
    public long Id { get; set; }

    [Required]
    [StringLength(100)]
    [Column(TypeName = "VARCHAR")]
    public string Number { get; set; }

    [Required]
    public long HouseId { get; set; }

    public virtual List<Owner> Owners { get; set; }
    public virtual List<OwnerApartmentRelation> OwnerApartmentRelations { get; set; }
    public virtual House House { get; set; }
}