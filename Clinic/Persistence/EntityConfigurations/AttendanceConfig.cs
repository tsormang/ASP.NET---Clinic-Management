using Clinic.Models;
using System.Data.Entity.ModelConfiguration;

namespace Clinic.Persistence.EntityConfigurations
{
    public class AttendanceConfig : EntityTypeConfiguration<Attendance>
    {
        public AttendanceConfig()
        {
            Property(p => p.PatientId).IsRequired();
            Property(p => p.ClinicRemarks).IsRequired();
            Property(p => p.Diagnosis).IsRequired().HasMaxLength(255);
            Property(p => p.Therapy).IsRequired();
        }
    }
}