using Clinic.Models;
using System.Collections.Generic;

namespace Clinic.Repositories
{
    public interface IPatientRepo
    {
        IEnumerable<Patient> GetPatients();
        IEnumerable<Patient> GetRecentPatients();
        Patient GetPatient(int id);
        void Add(Patient patient);
        void Remove(Patient patient);
    }
}