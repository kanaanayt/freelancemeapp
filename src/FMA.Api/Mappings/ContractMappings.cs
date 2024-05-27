using System.Reflection.Emit;
using FMA.Application.Entities;
using FMA.Contracts.Responses;

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

    public static FreelancersResponse MapFreelancers(this IEnumerable<Freelancer> freelancers)
    {
        return new FreelancersResponse
        {
            Freelancers = freelancers.Select(MapFreelancer)
        };
    }

    public static FreelancerResponse MapFreelancer(this Freelancer freelancer)
    {
        var fr = new FreelancerResponse
        {
            Id = freelancer.Id,
            DomainId = freelancer.DomainId,
            FirstName = freelancer.FirstName,
            LastName = freelancer.LastName,
            DateRegistered = freelancer.DateRegistered,
            PhotoPath = freelancer.PhotoPath,
            Email = freelancer.Email,
            PhoneNumber = freelancer.PhoneNumber,
            HourlyRate = freelancer.HourlyRate,
            Rating = freelancer.Rating,
            FulfilledContracts = freelancer.FulfilledContracts,
            HoursBilled = freelancer.HoursBilled,
            Latitude = freelancer.Latitude,
            Longitude = freelancer.Longitude,
            IsActive = freelancer.IsActive,
            Expertises = new()
        };
        foreach (var e in freelancer.Expertises)
        {
            fr.Expertises.Add(e);
        }
        return fr;
    }
}