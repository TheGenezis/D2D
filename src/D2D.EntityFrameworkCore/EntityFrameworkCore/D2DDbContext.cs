using Abp.Zero.EntityFrameworkCore;
using D2D.Authorization.Roles;
using D2D.Authorization.Users;
using D2D.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace D2D.EntityFrameworkCore
{
    public class D2DDbContext : AbpZeroDbContext<Tenant, Role, User, D2DDbContext>
    {
        /* Define an IDbSet for each entity of the application */
        
        public D2DDbContext(DbContextOptions<D2DDbContext> options)
            : base(options)
        {

        }
    }
}
