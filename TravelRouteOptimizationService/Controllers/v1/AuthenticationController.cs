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


        public AuthenticationController(IAuthenticationService authenticationService) {
            this._authenticationService = authenticationService;
        }

        [HttpPost]
        [Route("LogIn")]
        public async System.Threading.Tasks.Task<ActionResult<LoginResponse>> LoginAsync(LoginRequest loginRequest) 
        {
            LoginResponse result = new LoginResponse();
            bool isSuccess = await _authenticationService.login(loginRequest.UserName, loginRequest.Password);
            if (isSuccess)
            {
                result.IsSuccessful = true;
                return Ok(result);
            }
            else {
                result.IsSuccessful = false;
                result.ErrorMessage = "Kullanıcı adı veya şifre hatalı";
                return BadRequest(result);
            }
           
        }

        [HttpPost]
        [Route("SignIn")]
        public async System.Threading.Tasks.Task<ActionResult<SignInResponse>> SignInAsync(SignInRequest signInRequest) {
            SignInResponse result = new SignInResponse();
            bool isSuccess = await _authenticationService.signIn(signInRequest.Name, signInRequest.Surname, signInRequest.Email,signInRequest.Password);
            if (isSuccess)
            {
                result.IsSuccessful = true;
                return Ok(result);
            }
            else
            {
                result.IsSuccessful = false;
                result.ErrorMessage = "İşlem başarısız";
                return BadRequest(result);
            }
        }
    }
}
