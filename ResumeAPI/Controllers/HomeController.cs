using Microsoft.AspNetCore.Mvc;

namespace ResumeAPI.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : Controller
    {
        [HttpGet(Name = "GetSkillsList")]
        public IEnumerable<string> Get()
        {
            List<string> skills = new List<string>(){ "SQL", "C#", "ASP.NET Core" };
            return skills.ToArray();
        }
    }
}
