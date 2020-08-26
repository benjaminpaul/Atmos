using System.Threading.Tasks;
using Atmos.Domain.Data.AppConfig;
using Atmos.Domain.Model.AppConfig;
using Atmos.Domain.Models.AppConfig;
using Microsoft.AspNetCore.Mvc;

namespace Atmos.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppConfigController : ControllerBase
    {
        private readonly IAppConfigRepository _appConfigRepository;

        public AppConfigController(IAppConfigRepository appConfigRepository)
        {
            _appConfigRepository = appConfigRepository;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetConfiguration()
        {
            var config = await _appConfigRepository.GetAppConfig();
            return Ok(config);
        }
    }
}