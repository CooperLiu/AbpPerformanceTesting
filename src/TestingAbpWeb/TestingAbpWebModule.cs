using Microsoft.AspNetCore.Builder;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace TestingAbpWeb
{
    [DependsOn(typeof(AbpAutofacModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class TestingAbpWebModule : AbpModule
    {
        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            var app = context.GetApplicationBuilder();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}