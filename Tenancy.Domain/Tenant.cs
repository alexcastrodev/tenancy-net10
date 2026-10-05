namespace Tenancy.Domain;

public class Tenant
{
    public Guid Id { get; private set; }
    
    public string Subdomain { get; private set; }

    public Tenant(string subdomain)
    {
        Id = Guid.CreateVersion7();
        Subdomain = subdomain;
    }
}
