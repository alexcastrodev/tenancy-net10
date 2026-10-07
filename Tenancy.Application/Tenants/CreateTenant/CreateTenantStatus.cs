namespace Tenancy.Application.Tenants.CreateTenant;

public enum CreateTenantStatus
{
    Created,
    InvalidSubdomain,
    SubdomainTaken
}