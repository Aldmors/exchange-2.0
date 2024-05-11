using Microsoft.EntityFrameworkCore;
using ExchangeServer.Data;

namespace ExchangeServer;

public static class MigrationExtensions
{
    public static void ApplyMigrations(this IApplicationBuilder app)
    {
        using IServiceScope scope = app.ApplicationServices.CreateScope();
        
        using ExchangeServerContext dbContext = scope.ServiceProvider.GetRequiredService<ExchangeServerContext>();

        dbContext.Database.Migrate();
    }
}