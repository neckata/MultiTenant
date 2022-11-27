using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Multitenant.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService _service;

        public ProjectsController(IProjectService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync(int id)
        {
            var projectDetails = await _service.GetByIdAsync(id);
            return Ok(projectDetails);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateProjectRequest request)
        {
            return Ok(await _service.CreateAsync(request.Name, request.Description));
        }
    }

    public class CreateProjectRequest
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}