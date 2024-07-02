using Microsoft.EntityFrameworkCore;
using PayNowWeb.Infrastructure;

namespace PayNowWeb.Extensions;

public static class ServiceProviderExtensions
{
    public static DatabaseContext MigrateDatabase(this IServiceProvider serviceProvider)
    {
        var dbContext = serviceProvider.GetRequiredService<DatabaseContext>();
        dbContext.Database.Migrate();

        return dbContext;
    }
}