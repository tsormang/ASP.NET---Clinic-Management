using Clinic.Models;
using System.Collections.Generic;

namespace Clinic.Repositories
{
    public interface IAttendanceRepo
    {
        IEnumerable<Attendance> GetAttandences();
        IEnumerable<Attendance> GetAttendance(int id);
        IEnumerable<Attendance> GetPatientAttandences(string searchTerm = null);
        int CountAttendances(int id);
        void Add(Attendance attendance);
    }
}