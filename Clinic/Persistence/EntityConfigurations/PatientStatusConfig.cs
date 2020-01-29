using Clinic.Models;
using System.Data.Entity.ModelConfiguration;

namespace Clinic.Persistence.EntityConfigurations
{
    public class PatientStatusConfig : EntityTypeConfiguration<PatientStatus>
    {
        public PatientStatusConfig()
        {
            Property(s => s.Name).IsRequired().HasMaxLength(255);
        }
    }
}