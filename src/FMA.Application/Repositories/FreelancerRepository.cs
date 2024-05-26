using System.Reflection.Emit;
using FMA.Application.Data;
using FMA.Application.Entities;
using Microsoft.EntityFrameworkCore;

namespace FMA.Application.Repositories;

public class FreelancerRepository : IFreelancerRepository
{
    private readonly FreelancerContext _db;
    public FreelancerRepository(FreelancerContext context)
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
    
}
