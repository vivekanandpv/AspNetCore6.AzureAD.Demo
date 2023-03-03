using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;

namespace AspNetCore6.AzureAD.Demo.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    [RequiredScope(RequiredScopesConfigurationKey = "AzureAD:Scope")]
    public class DashboardController : ControllerBase
    {
        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public async Task<IActionResult> GetDashboard()
        {
            return await Task.FromResult(Ok(new { Files = 124, Status = "OK" }));
        }
    }
}
