using Microsoft.Extensions.DependencyInjection;
using System;
using Volo.Abp;

namespace BasicConsoleSample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var application = AbpApplicationFactory.Create<ConsoleModule>())
            {
                application.Initialize();

                var helloService = application.ServiceProvider.GetService<HelloAbpService>();

                helloService.SayHello();
                application.Shutdown();
            }

            Console.Read();
        }
    }
}