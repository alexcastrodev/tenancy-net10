using Tenancy.Domain;

namespace Tenancy.Application.Tenants.CreateTenant;

public sealed class CreateTenantHandler(ITenantRepository tenants)
{
    public async Task<CreateTenantResult> HandleAsync(string subdomain, CancellationToken cx)
    {
        Tenant tenant;
        try
        {
            tenant = new Tenant(subdomain);
        }
        catch (ArgumentException ex)
        {
            return new CreateTenantResult(Status: CreateTenantStatus.InvalidSubdomain, Error: ex.Message);
        }
        
        await tenants.AddAsync(tenant, cx);

        return new CreateTenantResult(
            Status: CreateTenantStatus.Created,
            Tenant: tenant
        );
    }
}
