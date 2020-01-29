using Clinic.Models;
using System.Linq;
using Clinic.Repositories;
using Clinic.ViewModel;
using System.Collections.Generic;

namespace Clinic.Persistence.Repos
{
    public class ApplicationUserRepo : IApplicationUserRepo
    {
        private readonly ApplicationDbContext _context;

        public ApplicationUserRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<UserViewModel> GetUsers()
        {
            return (from user in _context.Users
                    from userRole in user.Roles
                    join role in _context.Roles
                        on userRole.RoleId equals role.Id
                    select new UserViewModel()
                    {
                        Id = user.Id,
                        Email = user.Email,
                        Role = role.Name,
                        IsActive = user.IsActive
                    }).ToList();
        }

        public ApplicationUser GetUser(string id)
        {
            return _context.Users.Find(id);
        }
    }
}