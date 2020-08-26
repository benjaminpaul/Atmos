using System.Threading.Tasks;
using Atmos.Domain.Models.AppConfig;
using Microsoft.Extensions.Configuration;

namespace Atmos.Domain.Data.AppConfig
{
    public class AppConfigRepository : IAppConfigRepository
    {
        private readonly IConfiguration _configuration;

        public AppConfigRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        
        public async Task<Model.AppConfig.AppConfig> GetAppConfig()
        {
            var title = _configuration["AppConfig:AppTitle"];
            return new Model.AppConfig.AppConfig()
            {
                AppTitle = title,
                LandingConfig = new LandingConfig
                {
                    LandingTitle =
                        "Your digital place for focus. Mix different sounds and create your perfect sound environment to work and relax.",
                    LandingText =
                        "We provide background sounds that help to mask annoying noises in order to keep you sane, improve your focus and boost your productivity."
                }
            };
        }
    }
}