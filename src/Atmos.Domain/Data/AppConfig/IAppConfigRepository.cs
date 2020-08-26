using System.Threading.Tasks;

namespace Atmos.Domain.Data.AppConfig
{
    public interface IAppConfigRepository
    {
        Task<Model.AppConfig.AppConfig> GetAppConfig();
    }
}