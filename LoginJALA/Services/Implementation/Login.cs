using LoginJALA.Migrations;
using LoginJALA.Model;
using LoginJALA.Services.Interface_;

namespace LoginJALA.Services.Implementation
{
    public class Login:ILogin
    {
        public readonly LoginDBContext dbContext;
        private readonly UserDetails<LoginDetails> _loginDetails;
        private readonly AdminLoginDetails<AdminLoginDetails> _adminLoginDetails;

        public Login(LoginDBContext _dbContext)
        {
           dbContext = _dbContext;
        }

        public LoginDetails LoginCheck(string username, string password)
        {
            var user=
        }
    }
}
