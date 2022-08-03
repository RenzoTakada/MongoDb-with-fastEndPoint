using Adapters.MongoDb.Service;
using Adapters.MongoDb.Settings;

namespace Adapters.MongoDb.Extensions
{
    public static class MongoDBExtensions
    {
        public static IServiceCollection AddMongoAdapter(this IServiceCollection services)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                     .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json")
                     .Build();


            services.Configure<MongoDBSettings>(options => configuration.GetSection("MongoDB").Bind(options));
            services.AddSingleton<IMongoService, MongoService>();

            return services;
        }
    }
}
