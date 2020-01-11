using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_JwtToken.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessController : Controller
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetData()
        {
            //lord of the rings swords
            return new string[] { "lord of the rings swords", "Anduril", "Glamdring", "Orcrist (Goblin-doğrayan)", "Sting (İğne)", "Narsil", "Morgul kılıcı", "Gurthang", "Herugrim" };
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetCharacter()
        {
            //lord of the rings characters
            return new [] { "lord of the rings character", "Balrog", "Uruk-Hai", "Melkor(Morgoth)", "Azog", "Mouth Of Sauron", "Sauron", "Smaug", "Er-Murazor (Witch King)" , "Bolg", "Ancalagon", "Ungoliant", "Gothmog" };
        }
    }
}