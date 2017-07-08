using D2D.Configuration;
using D2D.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace D2D.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class D2DDbContextFactory : IDbContextFactory<D2DDbContext>
    {
        public D2DDbContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<D2DDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            D2DDbContextConfigurer.Configure(builder, configuration.GetConnectionString(D2DConsts.ConnectionStringName));
            
            return new D2DDbContext(builder.Options);
        }
    }
}