using Clinic.Models;
using System.Collections.Generic;

namespace Clinic.Repositories
{
    public interface ISpecializationRepo
    {
        IEnumerable<Specialization> GetSpecializations();
    }
}