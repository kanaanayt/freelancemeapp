using System.Reflection.Emit;
using FMA.Application.Data;
using FMA.Application.Entities;
using Microsoft.EntityFrameworkCore;

namespace FMA.Application.Repositories;

public class FreelanceMeRepository : IFreelanceMeRepository
{
    private readonly FreelancerContext _db;
    public FreelanceMeRepository(FreelancerContext context)
    {
        _db = context;
    }

    public async Task<IEnumerable<Domain>> GetDomainsAsync()
    {
        return await _db.Domains.ToListAsync();
    }

    public async Task<Domain> GetDomainAsync(int domainId)
    {
        return await _db.Domains.SingleOrDefaultAsync(d => d.Id == domainId);
    }

    public async Task<IEnumerable<Freelancer>> GetFreelancersAsync(int domainId)
    {
        return await _db.Freelancers
            .Include(f => f.Expertises)
            .Where(f => f.DomainId == domainId)
            .ToListAsync();
    }

    public async Task<Freelancer> GetFreelancerByIdAsync(
        int domainId, int freelancerId)
    {
        return await _db.Freelancers
            .Include(f => f.Expertises)
            .SingleOrDefaultAsync(f => f.DomainId == domainId && f.Id == freelancerId);
    }

    public async Task<IEnumerable<Freelancer>> GetAllFreelancersAsync()
    {
        return await _db.Freelancers.Include(f => f.Expertises).ToListAsync();
    }

    public async Task<IEnumerable<Expertise>> GetSomeExpertisesAsync(int below, int above)
    {
        return await _db.Expertises
            .Include(e => e.Freelancers)
            .Where(e => e.Id >= below && e.Id <= above)
            .ToListAsync();
    }
}
