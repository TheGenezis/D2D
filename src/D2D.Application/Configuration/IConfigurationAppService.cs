using System.Threading.Tasks;
using D2D.Configuration.Dto;

namespace D2D.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}