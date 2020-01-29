using Clinic.Models;
using Clinic.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Clinic.Persistence.Repos
{
    public class CityRepo : ICityRepo
    {

        private readonly ApplicationDbContext _context;

        public CityRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<City> GetCities()
        {
            return _context.Cities.ToList();
        }

    }
}