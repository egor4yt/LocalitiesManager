using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocalitiesManager.Data.Entities;

public class Owner : EntityBase
{
    public long Id { get; set; }

    [Required]
    [StringLength(100)]
    [Column(TypeName = "VARCHAR")]
    public string FirstName { get; set; }

    [Required]
    [StringLength(100)]
    [Column(TypeName = "VARCHAR")]
    public string LastName { get; set; }

    [StringLength(100)]
    [Column(TypeName = "VARCHAR")]
    public string Surname { get; set; }

    public virtual List<Apartment> Apartments { get; set; }
    public virtual List<OwnerApartmentRelation> OwnerApartmentRelations { get; set; }
}