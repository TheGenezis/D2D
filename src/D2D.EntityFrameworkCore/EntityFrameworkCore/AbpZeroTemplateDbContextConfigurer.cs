using Microsoft.EntityFrameworkCore;

namespace D2D.EntityFrameworkCore
{
    public static class D2DDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<D2DDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }
    }
}