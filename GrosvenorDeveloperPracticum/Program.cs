using System;
using GrosvenorDeveloperPracticum.Application.Services;
using GrosvenorDeveloperPracticum.Console;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Terminal = System.Console;

namespace GrosvenorInHousePracticum.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using IHost host = new IoC().BuildHost(args);

            Run(host.Services);

            host.RunAsync().Wait();
        }

        static void Run (IServiceProvider services) {

            using IServiceScope serviceScope = services.CreateScope();
            IServiceProvider serviceProvider = serviceScope.ServiceProvider;

            IWaiterService waiterService = serviceProvider.GetRequiredService<IWaiterService>();

            while (true)
            {
                var unparsedOrder = Terminal.ReadLine();
                var output = waiterService.TakeOrder(unparsedOrder);
                Terminal.WriteLine(output);
            }
        }
    }
}
