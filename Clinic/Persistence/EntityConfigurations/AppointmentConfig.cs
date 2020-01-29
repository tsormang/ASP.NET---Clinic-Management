using Clinic.Models;
using System.Data.Entity.ModelConfiguration;

namespace Clinic.Persistence.EntityConfigurations
{
    public class AppointmentConfig : EntityTypeConfiguration<Appointment>
    {
        public AppointmentConfig()
        {
            Property(a => a.PatientId).IsRequired();
            Property(a => a.DoctorId).IsRequired();
            Property(a => a.StartDateTime).IsRequired();
            Property(a => a.Detail).IsRequired();
            Property(a => a.Status).IsRequired();
        }
    }
}