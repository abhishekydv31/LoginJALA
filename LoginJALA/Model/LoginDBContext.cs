using Microsoft.EntityFrameworkCore;

namespace LoginJALA.Model
{
    public class LoginDBContext:DbContext
    {
        public LoginDBContext(DbContextOptions options):base(options)
        { 
            
        }

        public DbSet<LoginModel> LoginModels { get; set; }
        public DbSet<AdminLoginDetails> AdminLoginDetails { get; set; }
    }
}
