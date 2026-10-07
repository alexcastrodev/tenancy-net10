using Tenancy.Application.Tenants.CreateTenant;
using Tenancy.Domain;

namespace Tenancy.Infrastructure.Persistence;

internal sealed class TenantRepository(TenancyDbContext context) : ITenantRepository
{
    public Task<bool> ExistsAsync(string subdomain)
    {
        throw new NotImplementedException();
    }

    public Task<Tenant?> FindBySubdomainAsync(string subdomain, CancellationToken cx)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(Tenant tenant, CancellationToken cx)
    {
        throw new NotImplementedException();
    }

    public Task<Tenant?> FindBySubdomainAsync(string subdomain)
    {
        throw new NotImplementedException();
    }
}