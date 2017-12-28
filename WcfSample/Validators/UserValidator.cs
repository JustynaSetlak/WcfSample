using System.IdentityModel.Selectors;
using System.Security.Authentication;

namespace WcfSample.Validators
{
    public class UserValidator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (userName != "test" || password != "test123")
            {
                throw new AuthenticationException("Incorrect username or password");
            }
        }
    }
}