using FMA.Application.Entities;

namespace FMA.Application.Repositories;

public interface IFreelanceMeRepository
{
    Task<IEnumerable<Domain>> GetDomainsAsync();
    Task<Domain> GetDomainAsync(int domainId);
    Task<IEnumerable<Freelancer>> GetFreelancersAsync(int domainId);
    Task<Freelancer> GetFreelancerByIdAsync(int domainId, int freelancerId);
    Task<IEnumerable<Freelancer>> GetAllFreelancersAsync();
    Task<IEnumerable<Expertise>> GetSomeExpertises(int below, int above);
}