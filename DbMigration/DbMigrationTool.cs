using DbUp;
using Microsoft.Extensions.Configuration;

namespace DbMigration
{
    public static class DbMigrationTool
    {
        public static void Migrate(IConfiguration configuration)
        {
            //var connectionString = configuration.GetConnectionString("following") ?? 
            //    configuration.GetSection(" ").Value;

            var connectionString = configuration.GetConnectionString("DefaultConnection")
                ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

            EnsureDatabase.For.SqlDatabase(connectionString);

            var upgrader = 
                DeployChanges.To
                .SqlDatabase(connectionString)
                .WithScriptsEmbeddedInAssembly(typeof(DbMigrationTool).Assembly)
                .LogToConsole()
                .WithTransaction()
                .Build();

            var result = upgrader.PerformUpgrade();

            if (!result.Successful)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(result.Error);
                Console.ResetColor();

                Console.ReadLine();
                Environment.Exit(-1);
            }
        }


    }
}
