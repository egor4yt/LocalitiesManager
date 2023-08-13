using LocalitiesManager.Data.Entities;
using LocalitiesManager.Data.SeedData;
using Microsoft.EntityFrameworkCore;

namespace LocalitiesManager.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Owner> Owners { get; set; }
    public DbSet<Apartment> Apartments { get; set; }
    public DbSet<House> Houses { get; set; }
    public DbSet<Street> Streets { get; set; }
    public DbSet<Locality> Localities { get; set; }
    public DbSet<LocalityType> LocalityTypes { get; set; }
    public DbSet<StreetType> StreetTypes { get; set; }
    public DbSet<OwnerApartmentRelation> OwnerApartmentRelations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        UpdateStructure(modelBuilder);
        SeedData(modelBuilder);

        base.OnModelCreating(modelBuilder);
    }

    private static void UpdateStructure(ModelBuilder builder)
    {
        builder.Entity<Locality>()
            .HasOne(p => p.LocalityType)
            .WithMany(p => p.Localities)
            .HasForeignKey(p => p.LocalityTypeId);

        builder.Entity<Street>()
            .HasOne(p => p.StreetType)
            .WithMany(p => p.Streets)
            .HasForeignKey(p => p.StreetTypeId);

        builder.Entity<Street>()
            .HasOne(p => p.Locality)
            .WithMany(p => p.Streets)
            .HasForeignKey(p => p.LocalityId);

        builder.Entity<House>()
            .HasOne(p => p.Street)
            .WithMany(p => p.Houses)
            .HasForeignKey(p => p.StreetId);

        builder.Entity<Apartment>()
            .HasOne(p => p.House)
            .WithMany(p => p.Apartments)
            .HasForeignKey(p => p.HouseId);

        builder.Entity<Owner>()
            .HasMany(owner => owner.Apartments)
            .WithMany(apartment => apartment.Owners)
            .UsingEntity<OwnerApartmentRelation>(
                entity => entity
                    .HasOne(p => p.Apartment)
                    .WithMany(p => p.OwnerApartmentRelations)
                    .HasForeignKey(p => p.ApartmentId),
                entity => entity
                    .HasOne(p => p.Owner)
                    .WithMany(p => p.OwnerApartmentRelations)
                    .HasForeignKey(p => p.OwnerId),
                entity =>
                {
                    entity.Property(p => p.CreatedAt).HasDefaultValueSql("CURRENT_TIMESTAMP"); // WORKING ONLY WITH POSTGRES
                    entity.Property(p => p.Id).ValueGeneratedOnAdd();
                    entity.HasKey(p => new { p.OwnerId, p.ApartmentId });
                }
            );
    }

    private static void SeedData(ModelBuilder builder)
    {
        var localityTypes = LocalityTypesSeed.Get();
        builder.Entity<LocalityType>().HasData(localityTypes);

        var streetTypes = StreetTypesSeed.Get();
        builder.Entity<StreetType>().HasData(streetTypes);

        var localities = LocalitiesSeed.Get();
        builder.Entity<Locality>().HasData(localities);

        var owners = OwnersSeed.Get();
        builder.Entity<Owner>().HasData(owners);
    }
}