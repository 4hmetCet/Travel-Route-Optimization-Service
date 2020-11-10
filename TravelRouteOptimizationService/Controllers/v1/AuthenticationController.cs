using System;
using Microsoft.AspNetCore.Mvc;
using NetCoreBasicApi.Model.Contracts;
using TravelRouteOptimizationService.Services.ServiceImplementations;

namespace NetCoreBasicApi.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;


        AuthenticationController(IAuthenticationService authenticationService) {
            this._authenticationService = authenticationService;
        }

        [HttpPost]
        [Route("LogIn")]
        public LoginResponse Login(LoginRequest loginRequest) 
        {
            LoginResponse result = new LoginResponse();
            _authenticationService.login();
            result.IsSuccessful = true;
            return result;
        }

        [HttpPost]
        [Route("SignIn")]
        public SignInResponse SignIn(SignInRequest signInRequest) {
            SignInResponse result = new SignInResponse();
            _authenticationService.signIn();
            result.IsSuccessful = true;
            return result;
        }
    }
}
