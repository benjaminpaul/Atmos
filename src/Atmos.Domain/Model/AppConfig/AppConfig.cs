using Atmos.Domain.Models.AppConfig;

namespace Atmos.Domain.Model.AppConfig
{
    public class AppConfig
    {
        public string AppTitle { get; set; }
        public LandingConfig LandingConfig { get; set; } = new LandingConfig();
    }
}