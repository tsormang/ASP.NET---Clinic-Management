using Clinic.Models;
using System.Data.Entity.ModelConfiguration;

namespace Clinic.Persistence.EntityConfigurations
{
    public class SpecializationConfig : EntityTypeConfiguration<Specialization>
    {
        public SpecializationConfig()
        {
            Property(s => s.Name).IsRequired().HasMaxLength(255);
        }
    }
}