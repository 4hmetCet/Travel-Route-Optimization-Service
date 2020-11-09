using System;
using Microsoft.AspNetCore.Mvc;
using NetCoreBasicApi.Model.Contracts;

namespace NetCoreBasicApi.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AuthenticationController : ControllerBase
    {
        [HttpPost]
        [Route("LogIn")]
        public LoginResponse Login(LoginRequest loginRequest) 
        {
            LoginResponse result = new LoginResponse();
            result.IsSuccessful = true;
            return result;
        }

        [HttpPost]
        [Route("SignIn")]
        public SignInResponse SignIn(SignInRequest signInRequest) {
            SignInResponse result = new SignInResponse();
            result.IsSuccessful = true;
            return result;
        }
    }
}
