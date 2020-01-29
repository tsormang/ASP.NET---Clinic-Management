using Clinic.Models;
using Clinic.ViewModel;
using System.Collections.Generic;

namespace Clinic.Repositories
{
    public interface IApplicationUserRepo
    {
        List<UserViewModel> GetUsers();
        ApplicationUser GetUser(string id);
    }
}