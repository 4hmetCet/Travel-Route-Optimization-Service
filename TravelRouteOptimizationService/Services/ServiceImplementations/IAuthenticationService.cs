using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelRouteOptimizationService.Services.ServiceImplementations
{
    public interface IAuthenticationService
    {
        public Task<Boolean> login(String email, String password);
        public Task<Boolean> signIn(String name, String surname, String email, String password);

    }
}
