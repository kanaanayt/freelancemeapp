using FMA.Application.Entities;

namespace FMA.Application.Repositories;

public interface IFreelanceMeRepository
{
    Task<IEnumerable<Domain>> GetDomainsAsync();
    Task<Domain> GetDomainAsync(int domainId);
    Task<IEnumerable<Freelancer>> GetFreelancersAsync(int domainId);
    Task<Freelancer> GetFreelancerByIdAsync(int domainId, int freelancerId);
    Task<IEnumerable<Freelancer>> GetAllFreelancersAsync();
    Task<IEnumerable<Expertise>> GetSomeExpertisesAsync(int domainId, int below, int above);
    Task<Expertise> GetExpertiseAsync(int id);
}