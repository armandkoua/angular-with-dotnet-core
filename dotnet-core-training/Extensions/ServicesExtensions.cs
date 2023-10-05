using Interfaces;
using LoggerService;

namespace dotnet_core_training.Extensions
{
    public static class ServicesExtensions
    {
        public static void ConfigureLoggingServices(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }
    }
}
