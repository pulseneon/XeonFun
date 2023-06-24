using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using XeonFun.Entites.Requests;
using XeonFun.Services.Service;

namespace XeonFun.Controllers.Products
{
    [Route("api/products/[controller]")]
    [ApiController]
    public class VideocardController : ControllerBase
    {
        private readonly VideocardService _service;
        public VideocardController(VideocardService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetVideocard(int id)
        {
            var videocard = await _service.GetVideocard(id);

            if (videocard == null)
            {
                return NotFound();
            }

            return Ok(videocard);
        }

        //[Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> AddVideocard([FromBody] VideocardRequest videocard)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = await _service.AddVideocard(videocard);

            return Ok(result);
        }
    }
}
