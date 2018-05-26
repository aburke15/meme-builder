using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MemeBuilder.Interfaces;
using MemeBuilder.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MemeBuilder.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class TemplateController : Controller
    {
        private readonly ITemplateRepository TemplateRepository;

        public TemplateController(ITemplateRepository templateRepository) 
            => TemplateRepository = templateRepository;

        [HttpGet("{id:guid}")]
        public IActionResult GetTemplate(Guid id)
        {
            var template = TemplateRepository.GetByIdAsync(id);

            return Ok(template);
        }

        [HttpGet]
        public IActionResult GetTemplates()
        {
            var templates = TemplateRepository.GetAsync();

            return Ok(templates);
        }

        [HttpPost]
        public IActionResult CreateTemplate() 
        {
            var template = new Template()
            {
                Description = "First meme template!"
            };

            TemplateRepository.Add(template);

            return Created("", "Succesfully saved a template");
        }
    }
}
