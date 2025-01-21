using Microsoft.AspNetCore.Mvc;
using ResumeAPI.Data.Context;
using ResumeAPI.Data.Models;

namespace ResumeAPI.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : Controller
    {
        private readonly ResumeAPIContext _dbContext;
        public HomeController(ResumeAPIContext context)
        {
            _dbContext = context;
        }

        [HttpGet(Name = "GetSkillsList")]
        public IEnumerable<Skills> Get()
        {

            var skills = _dbContext.Skills.ToArray();
            return skills;
        }
    }
}
