using Microsoft.EntityFrameworkCore;
using Tenancy.Domain;

namespace Tenancy.Infrastructure.Persistence;

internal sealed class TenancyDbContext(DbContextOptions options) : DbContext(options)
{

    public DbSet<Tenant> Tenants => Set<Tenant>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(TenancyDbContext).Assembly);
    }
}
