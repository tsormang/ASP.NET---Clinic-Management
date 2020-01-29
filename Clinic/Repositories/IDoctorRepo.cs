using Clinic.Models;
using System.Collections.Generic;

namespace Clinic.Repositories
{
    public interface IDoctorRepo
    {
        IEnumerable<Doctor> GetDectors();
        IEnumerable<Doctor> GetAvailableDoctors();
        Doctor GetDoctor(int id);
        Doctor GetProfile(string userId);
        void Add(Doctor doctor);
    }
}