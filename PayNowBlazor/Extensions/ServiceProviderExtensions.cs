using Microsoft.EntityFrameworkCore;
using PayNowBlazor.Infrastructure;

namespace PayNowBlazor.Extensions;

public static class ServiceProviderExtensions
{
    public static DatabaseContext MigrateDatabase(this IServiceProvider services)
    {
        var dbContext = services.GetRequiredService<DatabaseContext>();
        dbContext.Database.Migrate();

        return dbContext;
    }
}