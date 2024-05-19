using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace TeamHost.Persistence.Context;


public class EfContextFactory : IDesignTimeDbContextFactory<EfContext>
{
   
    public EfContext CreateDbContext(string[] args)
    {
        var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", false)
            .AddEnvironmentVariables()
            .Build();
        
        var optionBuilder = new DbContextOptionsBuilder<EfContext>();
        optionBuilder.UseNpgsql(config.GetConnectionString("DefaultConnection"));

        return new EfContext(optionBuilder.Options);
    }
}