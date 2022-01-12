using api.Data;
using Microsoft.EntityFrameworkCore;

namespace api
{
    public static class MigrationManager
    {
        public static IHost MigrateDatabase(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                using (var appContext = scope.ServiceProvider.GetRequiredService<ApiContext>())
                {
                    try
                    {
                        appContext.Database.Migrate();
                        Console.WriteLine("Migrations complete");
                    }
                    catch (Exception ex)
                    {
                        // eventually log this error
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            return host;
        }
    }
}
