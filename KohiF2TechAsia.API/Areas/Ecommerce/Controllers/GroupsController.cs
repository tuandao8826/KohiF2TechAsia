using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KohiF2TechAsia.API.Areas.Ecommerce.Controllers
{
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Area("Ecommerce")]
    [ApiExplorerSettings(GroupName = "Ecommerce")]

    public class GroupsController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }
    }
}
