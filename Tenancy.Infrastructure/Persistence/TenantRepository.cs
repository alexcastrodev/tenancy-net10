using Microsoft.EntityFrameworkCore;
using Tenancy.Application.Tenants.CreateTenant;
using Tenancy.Domain;

namespace Tenancy.Infrastructure.Persistence;

internal sealed class TenantRepository(TenancyDbContext db) : ITenantRepository
{
    public Task<bool> ExistsAsync(string subdomain, CancellationToken cx)
    {
        return db.Tenants.AnyAsync(t => t.Subdomain == subdomain, cx);
    }

    public Task<Tenant?> FindBySubdomainAsync(string subdomain, CancellationToken cx)
    {
        return db.Tenants.FirstOrDefaultAsync(t => t.Subdomain == subdomain, cx);
    }

    public async Task AddAsync(Tenant tenant, CancellationToken cx)
    {
        db.Tenants.Add(tenant);
        await db.SaveChangesAsync(cx);
    }
}