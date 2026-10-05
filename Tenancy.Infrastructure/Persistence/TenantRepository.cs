using Tenancy.Application.Tenants.CreateTenant;
using Tenancy.Domain;

namespace Tenancy.Infrastructure.Persistence;

public class TenantRepository : ITenantRepository
{
    public Task<bool> ExistsAsync(string subdomain)
    {
        throw new NotImplementedException();
    }

    public Task<Tenant?> FindBySubdomainAsync(string subdomain)
    {
        throw new NotImplementedException();
    }
}