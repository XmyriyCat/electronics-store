using Data;
using Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Extensions
{
    public static class ServicesExtension
    {
        public static void ConfigureDbConnection(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["ConnectionStrings:ElectronicsStoreConnection"];

            if (connectionString is null)
            {
                throw new ArgumentNullException($"Database connection string is null");
            }

            services.AddDbContext<ProductsDbContext>(opts =>
            {
                opts.UseSqlServer(connectionString);
            });
        }
    }
}
