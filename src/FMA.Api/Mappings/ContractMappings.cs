using System.Threading;
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
            Items = domains.Select(MapDomain).ToList()
        };
    }

    public static DomainResponse MapDomain(this Domain domain)
    {
        var response = new DomainResponse
        {
            Id = domain.Id,
            DomainName = domain.DomainName,
            PhotoPath = domain.PhotoPath,
        };
        foreach (var freelancer in domain.Freelancers)
        {
            response.Freelancers.Items.Add(freelancer.MapFreelancer());
        }
        foreach (var expertise in domain.Expertises)
        {
            response.Expertises.Items.Add(expertise.MapExpertise());
        }
        return response;
    }

    public static FreelancersResponse MapFreelancers(this List<Freelancer> freelancers)
    {
        return new FreelancersResponse
        {
            Items = freelancers.Select(MapFreelancer).ToList()
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
            Rating = freelancer.Rating,FulfilledContracts = freelancer.FulfilledContracts,
            HoursBilled = freelancer.HoursBilled,
            Latitude = freelancer.Latitude,
            Longitude = freelancer.Longitude,
            IsActive = freelancer.IsActive,
        };
        foreach (var e in freelancer.Expertises)
        {
            if (e.Id == freelancer.MainExpertiseId) 
            {
                response.MainExpertise = e.ExpertiseName;
            }
            else
            {
                response.OtherExpertises.Add(e.ExpertiseName);
            }
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
            Items = expertises.Select(MapExpertise).ToList()
        };
    }
}