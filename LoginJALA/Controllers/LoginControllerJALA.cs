using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoginJALA.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginControllerJALA : Controller
    {
        [HttpPost]
        public Task<IActionResult> LoginInfo(string username, string password)
        {
            try
            {

            }
            catch ()
            {

            }
        }
    }
}
