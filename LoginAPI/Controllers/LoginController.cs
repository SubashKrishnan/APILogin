using LoginAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace LoginAPI.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        [HttpPost("CheckLogin")]
        public int CheckLogin([FromBody]LoginModel login)
        {
            int status = 0;
            if (login.username == "admin" && login.password == "1")
            {
                status = 1;
            }
            return status;
        }
    }
}