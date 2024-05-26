using System.Reflection.Emit;
using FMA.Application.Entities;

namespace FMA.Api.Mappings;

public static class ContractMappings
{
    public static DomainsResponse MapDomains(this IEnumerable<Domain> domains)
    {
        return new DomainsResponse
        {
            Domains = domains.Select(MapDomain)
        };
    }

    public static DomainResponse MapDomain(this Domain domain)
    {
        return new DomainResponse
        {
            Id = domain.Id,
            DomainName = domain.DomainName,
            PhotoPath = domain.PhotoPath,
            FontFamily = domain.FontFamily
        };
    }
}