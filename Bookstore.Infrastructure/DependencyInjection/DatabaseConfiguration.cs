using Bookstore.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Bookstore.Infrastructure.DependencyInjection;

public static class DatabaseConfiguration
{
    public static void AddDatabaseConfiguration(
    this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddScoped<DbContext, ApplicationContext>();

        services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(
            connectionString: configuration.GetConnectionString(name: "DbConnection")));
    }
}
