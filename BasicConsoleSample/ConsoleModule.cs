using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Modularity;

namespace BasicConsoleSample
{
    public class ConsoleModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var service = context.Services;
            service.AddTransient<HelloAbpService>();
            base.ConfigureServices(context);
        }
    }
}
