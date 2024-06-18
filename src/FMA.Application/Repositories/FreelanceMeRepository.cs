using System.Reflection.Emit;
using System.Security.Principal;
using FMA.Application.Data;
using FMA.Application.Entities;
using Microsoft.EntityFrameworkCore;
using FMA.Contracts.Requests;

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
        return await _db.Domains
                        .Include(d => d.Freelancers)
                        .Include(d =>  d.Expertises)
                        .ToListAsync();
    }

    public async Task<Domain> GetDomainAsync(int domainId)
    {
        return await _db.Domains
            .Include(d => d.Freelancers)
            .SingleOrDefaultAsync(d => d.Id == domainId);
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

    public async Task<IEnumerable<Expertise>> GetExpertisesAsync()
    {
        return await _db.Expertises
            .Include(e => e.Freelancers)
            .ToListAsync();
    }
    public async Task<Expertise> GetExpertiseAsync(int id)
    {
        return await _db.Expertises.SingleOrDefaultAsync(e => e.Id == id);

    }

    public async Task<IEnumerable<Freelancer>> FilterFreelancers(FreelancerRequest request)
    {
        IQueryable<Freelancer> freelancers = _db.Freelancers.AsQueryable();
        freelancers = freelancers.Where(
            freelancer => request.Name.Contains(freelancer.FirstName) || request.Name.Contains(freelancer.LastName));

        freelancers = freelancers.Where(
            freelancer => freelancer.Expertises.Select(e => e.ExpertiseName).Equals(request.ExpertiseName)
        );

        return await freelancers.ToListAsync();
    }
}
