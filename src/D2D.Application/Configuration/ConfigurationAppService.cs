using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using D2D.Configuration.Dto;

namespace D2D.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : D2DAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
