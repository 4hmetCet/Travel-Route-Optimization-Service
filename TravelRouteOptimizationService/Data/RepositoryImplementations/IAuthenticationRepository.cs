using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelRouteOptimizationService.Model;

namespace TravelRouteOptimizationService.Data.RepositoryImplementations
{
    public interface IAuthenticationRepository
    {
        Task<User> GetUserByMailandPassword(String email, String password);
        Task<bool> InsertUser(String name, String surname, String email, String password);
    }
}
