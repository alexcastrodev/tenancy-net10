using Tenancy.Application.Tenants.CreateTenant;
using Tenancy.Domain;

namespace Tenancy.Application;

public record CreateTenantResult
(
    CreateTenantStatus Status,
    Tenant? Tenant = null,
    string? Error = null
);