using Microsoft.EntityFrameworkCore;

namespace Tenancy.Infrastructure.Persistence;

internal sealed class TenancyDbContext(DbContextOptions options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(TenancyDbContext).Assembly);
    }
}
