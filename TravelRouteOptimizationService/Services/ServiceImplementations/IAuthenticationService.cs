using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelRouteOptimizationService.Services.ServiceImplementations
{
    public interface IAuthenticationService
    {
        public Task<Boolean> login();
        public Task<Boolean> signIn();

    }
}
