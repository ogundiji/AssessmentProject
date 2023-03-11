using AssessmentProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssessmentProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        private readonly ISkillServices services;
        public SkillsController(ISkillServices services)
        {
            this.services = services;   
        }


        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var pp=await services.GetSkillsAsync();

            return Ok(pp);
        }


    }
}
