using Clinic.Models;
using Clinic.Persistence.EntityConfigurations;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Clinic.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<City> Cities { get; set; }

        public ApplicationDbContext()
            : base("ClinicDB", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PatientConfig());
            modelBuilder.Configurations.Add(new AppointmentConfig());
            modelBuilder.Configurations.Add(new DoctorConfig());
            modelBuilder.Configurations.Add(new AttendanceConfig());
            modelBuilder.Configurations.Add(new SpecializationConfig());
            modelBuilder.Configurations.Add(new CityConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}