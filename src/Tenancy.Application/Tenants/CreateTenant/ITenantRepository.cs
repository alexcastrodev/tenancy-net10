using Tenancy.Domain;

namespace Tenancy.Application.Tenants.CreateTenant;

public interface ITenantRepository
{
    Task<bool> ExistsAsync(string subdomain, CancellationToken cx);
    Task<Tenant?> FindBySubdomainAsync(string subdomain, CancellationToken cx);
    Task AddAsync(Tenant tenant, CancellationToken cx);
}