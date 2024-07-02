using PayNowWeb.Infrastructure;

namespace PayNowWeb.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddDatabase(this IServiceCollection services)
    {
        services.AddDbContext<DatabaseContext>(ServiceLifetime.Transient);
    }
}