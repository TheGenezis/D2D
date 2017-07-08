using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace D2D.Web.Views
{
    public abstract class D2DRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected D2DRazorPage()
        {
            LocalizationSourceName = D2DConsts.LocalizationSourceName;
        }
    }
}
