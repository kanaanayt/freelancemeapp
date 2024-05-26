using FMA.Application.Entities;

namespace FMA.Application.Repositories;

public interface IFreelancerRepository
{
    public Task<IEnumerable<Domain>> GetDomainsAsync();
    public Task<Domain> GetDomainAsync(int domainId);
}