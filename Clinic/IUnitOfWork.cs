using Clinic.Repositories;

namespace Clinic
{
    public interface IUnitOfWork
    {
        IPatientRepo Patients { get; }
        IAppointmentRepo Appointments { get; }
        IAttendanceRepo Attandences { get; }
        ICityRepo Cities { get; }
        IDoctorRepo Doctors { get; }
        ISpecializationRepo Specializations { get; }
        IApplicationUserRepo Users { get; }

        void Complete();
    }
}