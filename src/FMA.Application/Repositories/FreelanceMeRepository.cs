using System.Reflection.Emit;
using System.Security.Principal;
using FMA.Application.Data;
using FMA.Application.Entities;
using Microsoft.EntityFrameworkCore;
using FMA.Contracts.Requests;
using Geolocation;

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

        freelancers = freelancers.Where(freelancer =>
            request.Name.ToLower().Contains(freelancer.FirstName.ToLower()) 
            || 
            request.Name.ToLower().Contains(freelancer.LastName.ToLower()) 
            ||
			request.Email.ToLower().Contains(freelancer.Email.ToLower())
			||
            freelancer.Expertises.Any(expertise => expertise.ExpertiseName.Contains(request.ExpertiseName))
        );

		freelancers = freelancers.Where(freelancer =>
			freelancer.Rating >= request.MinRating 
			&& 
			freelancer.HourlyRate <= request.MaxHourlyRate
		);

        // freelancers = freelancers.Where(freelancer => 
        //     GetDistance(request.Latitude, request.Longitude, freelancer.Latitude, freelancer.Longitude).CompareTo(request.MaxDistance) < 0);

        var result =  await freelancers.ToListAsync();

        var freelancersFilteredByDistance = new List<Freelancer>();

        foreach (var freelancer in result)
        {
            if (GetDistance(request.Latitude, request.Longitude, freelancer.Latitude, freelancer.Longitude) <= request.MaxDistance)
            {
                freelancersFilteredByDistance.Add(freelancer);
            }
        }
        return freelancersFilteredByDistance;
    }

    public double GetDistance(double requestLatitude, double requestLongitude, double freelancerLatitude, double freelancerLongitude)
    {
        return GeoCalculator.GetDistance(requestLatitude, requestLongitude, freelancerLatitude, freelancerLongitude, 1, DistanceUnit.Kilometers);
    }
}

