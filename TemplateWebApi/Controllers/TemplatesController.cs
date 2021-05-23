using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TemplateWebApi.Data;
using TemplateWebApi.Models;

namespace TemplateWebApi.Controllers
{
    //api/commands
    //[Route("api/[controller]")]
    [Route("api/templates")]
    [ApiController]
    public class TemplatesController : ControllerBase
    {
        private readonly MockTemplateRepo _repository = new MockTemplateRepo();
        //GET api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Template>> GetAllCommands()
        {
            var templateItems = _repository.GetAppCommands();

            return Ok(templateItems);
        }
        //GET api/templates/{id}
        [HttpGet("{id}")]
        public ActionResult<Template> GetCommandById(int id)
        {
            var templateItem = _repository.GetCommandById(id);
            return Ok(templateItem);
        }
    }
}
