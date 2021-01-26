using System;
namespace NetCoreBasicApi.Model.Contracts
{
    public class SignInResponse
    {
        public SignInResponse()
        {
        }

        public bool IsSuccessful { get; set; }

        public string ErrorMessage { get; set; }
    }
}
