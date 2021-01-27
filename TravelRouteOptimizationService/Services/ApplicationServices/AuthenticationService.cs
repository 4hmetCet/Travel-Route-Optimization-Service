using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelRouteOptimizationService.Data.RepositoryImplementations;
using TravelRouteOptimizationService.Model;
using TravelRouteOptimizationService.Services.ServiceImplementations;

namespace TravelRouteOptimizationService.Services.ApplicationServices
{
    public class AuthenticationService : IAuthenticationService
    {
        public readonly IAuthenticationRepository _authenticationRepository;
        public AuthenticationService(IAuthenticationRepository authenticationRepository) {
            this._authenticationRepository = authenticationRepository;
        }
        public async Task<bool> login(String email, String password)
        {
            try
            {
                User user = await _authenticationRepository.GetUserByMailandPassword(email,password);
                if(user == null)
                    return false;
                return true;
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public async Task<bool> signIn(String name, String surname, String email, String password)
        {
            try
            {
                bool result = await _authenticationRepository.InsertUser(name,surname, email, password);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
