using Clinic.Models;
using System.Data.Entity.ModelConfiguration;

namespace Clinic.Persistence.EntityConfigurations
{
    public class DoctorConfig : EntityTypeConfiguration<Doctor>
    {
        public DoctorConfig()
        {
            Property(d => d.PhysicianId).IsRequired();
            Property(d => d.SpecializationId).IsRequired();
            Property(d => d.Name).IsRequired().HasMaxLength(255);
            Property(d => d.Phone).IsRequired();
        }
    }
}