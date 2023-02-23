using GrosvenorDeveloperPracticum.Application.Services;
using GrosvenorDeveloperPracticum.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GrosvenorDeveloperPracticum.Console
{
    public class IoC
    {
        public IHost BuildHost(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) =>
                services
                    .AddScoped<IWaiterService, WaiterService>()
                    .AddScoped<IMenuService, MenuService>()
                    .AddScoped<IOrderService, OrderService>()
                    .AddScoped<IPrintService, PrintService>()
            )
            .Build();
        }
    }
}
