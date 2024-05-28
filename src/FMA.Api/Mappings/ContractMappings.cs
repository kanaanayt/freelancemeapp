using System.Security.Cryptography;
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
            Items = domains.Select(MapDomain)
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
            Items = freelancers.Select(MapFreelancer)
        };
    }

    public static FreelancerResponse MapFreelancer(this Freelancer freelancer)
    {
        var response = new FreelancerResponse
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
        };
        foreach (var e in freelancer.Expertises)
        {
            response.ExpertiseNames.Add(e.ExpertiseName);
        }
        return response;
    }

    public static ExpertiseResponse MapExpertise(this Expertise expertise)
    {
        return new ExpertiseResponse
        {
            Id = expertise.Id,
            ExpertiseName = expertise.ExpertiseName,
            Freelancers = expertise.Freelancers.MapFreelancers()
        };
    }

    public static ExpertisesResponse MapExpertises(this IEnumerable<Expertise> expertises)
    {

        return new ExpertisesResponse
        {
            Items = expertises.Select(MapExpertise)
        };

    }
}