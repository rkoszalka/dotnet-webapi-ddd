namespace Koszalka.WebAPI.Auth
{
    namespace Koszalka.WebAPI.Auth
    {
        public interface IAuthService
        {
            Task<(int, string)> Registration(RegistrationModel model, string role);
            Task<(int, string)> Login(LoginModel model);
        }
    }

}
