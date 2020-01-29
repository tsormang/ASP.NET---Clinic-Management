using Clinic.Persistence.Repos;
using Clinic.Repositories;

namespace Clinic.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IPatientRepo Patients { get; private set; }
        public IAppointmentRepo Appointments { get; private set; }
        public IAttendanceRepo Attandences { get; private set; }
        public ICityRepo Cities { get; private set; }
        public IDoctorRepo Doctors { get; private set; }
        public ISpecializationRepo Specializations { get; private set; }
        public IApplicationUserRepo Users { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Patients = new PatientRepo(context);
            Appointments = new AppointmentRepo(context);
            Attandences = new AttendanceRepo(context);
            Cities = new CityRepo(context);
            Doctors = new DoctorRepo(context);
            Specializations = new SpecializationRepo(context);
            Users = new ApplicationUserRepo(context);

        }

        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}