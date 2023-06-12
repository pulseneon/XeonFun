using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace XeonFun.Controllers
{
    [Route("/health")]
    public class HealthController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> CheckHealthAsync()
        {
            var healthCheck = new HealthCheckResult();
            return BadRequest(healthCheck);
        }
    }
}
