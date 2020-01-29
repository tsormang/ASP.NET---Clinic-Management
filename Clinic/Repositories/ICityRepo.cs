using Clinic.Models;
using System.Collections.Generic;

namespace Clinic.Repositories
{
    public interface ICityRepo
    {
        IEnumerable<City> GetCities();
    }
}