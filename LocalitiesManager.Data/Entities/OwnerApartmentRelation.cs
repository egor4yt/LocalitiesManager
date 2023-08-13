namespace LocalitiesManager.Data.Entities;

public class OwnerApartmentRelation : EntityBase
{
    public long Id { get; set; }
    public long ApartmentId { get; set; }
    public long OwnerId { get; set; }

    public virtual Owner Owner { get; set; }
    public virtual Apartment Apartment { get; set; }
}