using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using D2D.Authorization;

namespace D2D
{
    [DependsOn(
        typeof(D2DCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class D2DApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<D2DAuthorizationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(D2DApplicationModule).GetAssembly());
        }
    }
}