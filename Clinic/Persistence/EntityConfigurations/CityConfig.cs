using Clinic.Models;
using System.Data.Entity.ModelConfiguration;

namespace Clinic.Persistence.EntityConfigurations
{
    public class CityConfig : EntityTypeConfiguration<City>
    {
        public CityConfig()
        {
            Property(p => p.Name).IsRequired().HasMaxLength(255);
        }
    }
}