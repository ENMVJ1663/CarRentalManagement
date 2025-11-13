using CarRentalManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Configurations.Entities
{
    public class VehicleSeed : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasData(
                    new Vehicle
                    {
                        Id = 1,
                        Year = 2023,
                        LicencePlateNumber = "M2183UKS",
                        MakeId = 1,
                        ModelId = 1,
                        ColourId = 1,
                        DateUpdated = DateTime.Now,
                        DateCreated = DateTime.Now,
                        UpdatedBy = "System",
                        CreatedBy = "System"

                    }
            );
        }
    }
}
