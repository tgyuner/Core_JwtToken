using Core_JwtToken.Helper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_JwtToken.Controllers
{
    /// <summary>
    /// The login controller
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.Controller" />
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private readonly IMyHelper _myHelper;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginController"/> class.
        /// </summary>
        /// <param name="myHelper">My helper.</param>
        public LoginController(IMyHelper myHelper)
        {
            _myHelper = myHelper;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("Login/{username}/{password}")]
        public ActionResult Login(string username, string password)
        {
            try
            {
                var logIn = _myHelper.LogIn(username, password);

                if (logIn == null)
                    return BadRequest(new { message = "Username or Password is Wrong!" });

                return Ok(logIn);
            }
            catch (System.Exception ex)
            {
                return BadRequest(new { message = "Username or Password is Wrong!" });
            }
        }
    }
}