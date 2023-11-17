using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Robozinho
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Host.CreateDefaultBuilder(args)
            .ConfigureServices((context, services) => services.AddHostedService<Service>())
            .Build()
            .Run();
        }
    }
}