using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KohiF2TechAsia.API.Areas.Admin.Controllers
{
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Area("Admin")]
    [ApiExplorerSettings(GroupName = "Admin")]

    public class ItemsController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }
    }
}
