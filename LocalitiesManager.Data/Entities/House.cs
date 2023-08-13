using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocalitiesManager.Data.Entities;

public class House : EntityBase
{
    public long Id { get; set; }

    [Required]
    [StringLength(100)]
    [Column(TypeName = "VARCHAR")]
    public string Number { get; set; }

    [Required]
    public long StreetId { get; set; }

    public virtual Street Street { get; set; }

    public virtual List<Apartment> Apartments { get; set; }
}