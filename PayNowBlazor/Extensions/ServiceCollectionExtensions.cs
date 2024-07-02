using PayNowBlazor.Infrastructure;

namespace PayNowBlazor.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddDatabase(this IServiceCollection services)
    {
        services.AddDbContext<DatabaseContext>(ServiceLifetime.Transient);
    }
}