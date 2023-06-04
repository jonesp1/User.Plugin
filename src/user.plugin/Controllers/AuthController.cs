using Microsoft.AspNetCore.Mvc;

namespace User.plugin.Controller
{

    [Route("api/[controller]")]
    [ApiController]

    public class AuthController
    {

        public static User user = new User();


        [HttpPost("register")]
        public ActionResult<User> Register(UserDto request)
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(request.password);
            user.username = request.username;
            user.passwordHash = passwordHash;

            return Ok(user);

        }



    }
}