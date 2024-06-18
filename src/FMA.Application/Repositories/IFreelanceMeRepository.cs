using FMA.Application.Entities;
using FMA.Contracts.Requests;
using FMA.Contracts.Responses;

namespace FMA.Application.Repositories;

public interface IFreelanceMeRepository
{
    Task<IEnumerable<Domain>> GetDomainsAsync();
    Task<Domain> GetDomainAsync(int domainId);
    Task<IEnumerable<Freelancer>> GetFreelancersAsync(int domainId);
    Task<Freelancer> GetFreelancerByIdAsync(int domainId, int freelancerId);
    Task<IEnumerable<Freelancer>> GetAllFreelancersAsync();
    Task<IEnumerable<Expertise>> GetExpertisesAsync();
    Task<Expertise> GetExpertiseAsync(int id);
    Task<IEnumerable<Freelancer>> FilterFreelancers(FreelancerRequest request);
}