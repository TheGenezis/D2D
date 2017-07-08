using System.Reflection;
using Abp.Modules;
using Abp.Reflection.Extensions;
using D2D.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace D2D.Web.Startup
{
    [DependsOn(typeof(D2DWebCoreModule))]
    public class D2DWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public D2DWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<D2DNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(D2DWebMvcModule).GetAssembly());
        }
    }
}