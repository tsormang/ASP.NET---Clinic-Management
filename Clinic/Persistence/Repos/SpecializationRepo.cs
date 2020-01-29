using Clinic.Models;
using Clinic.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Clinic.Persistence.Repos
{
    public class SpecializationRepo : ISpecializationRepo
    {
        public readonly ApplicationDbContext Context;

        public SpecializationRepo(ApplicationDbContext context)
        {
            Context = context;
        }

        public IEnumerable<Specialization> GetSpecializations()
        {
            return Context.Specializations.ToList();
        }
    }
}