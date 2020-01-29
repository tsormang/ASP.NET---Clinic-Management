using Clinic.Models;
using System.Data.Entity.ModelConfiguration;

namespace Clinic.Persistence.EntityConfigurations
{
    public class PatientConfig : EntityTypeConfiguration<Patient>
    {
        public PatientConfig()
        {
            Property(p => p.CityId).IsRequired();
            Property(p => p.Name).IsRequired().HasMaxLength(255);
            Property(p => p.Phone).IsRequired().HasMaxLength(255);
            Property(p => p.Address).IsRequired().HasMaxLength(255);
            Property(p => p.BirthDate).IsRequired();
            Property(p => p.Token).IsRequired();
            HasMany(p => p.Appointments)
                .WithRequired(a => a.Patient)
                .WillCascadeOnDelete(false);
        }
    }
}