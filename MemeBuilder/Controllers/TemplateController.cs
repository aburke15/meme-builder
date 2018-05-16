using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MemeBuilderData;
using MemeBuilderData.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MemeBuilder.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class TemplateController : Controller
    {
        private readonly MemeBuilderContext Context;

        public TemplateController(MemeBuilderContext context) 
            => Context = context;

        // GET: /<controller>/
        [HttpPost]
        public IActionResult CreateTemplate() 
        {
            var template = new Template()
            {
                Description = "First meme template!"
            };

            Context.Template.Add(template);
            Context.SaveChanges();

            return Ok("Successfully created a template");
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetTemplate(Guid id)
        {
            var template = Context.Template.Find(id.ToString());

            return Ok(template);
        }
    }
}
