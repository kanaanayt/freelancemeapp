using FMA.Api.Mappings;
using FMA.Application.Entities;
using FMA.Application.Repositories;
using Microsoft.AspNetCore.Mvc;
using FMA.Contracts.Responses;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace FMA.Api.Controllers;
[ApiController]
[Route("api")]
public class FreelanceMeController : ControllerBase
{
    private readonly IFreelanceMeRepository _repository;
    public FreelanceMeController(IFreelanceMeRepository repository)
    {
        _repository = repository;
    }

    [Route("domains")]
    [HttpGet]
    public async Task<ActionResult<DomainsResponse>> GetDomains()
    {
        var entities = await _repository.GetDomainsAsync();
        return entities.MapDomains();
    }

    [Route("domains/{id}")]
    [HttpGet]
    public async Task<ActionResult<DomainResponse>> GetDomain(int id)
    {
        var entity = await _repository.GetDomainAsync(id);
        return entity.MapDomain();
    }

    [Route("domains/{id}/freelancers")]
    [HttpGet]
    public async Task<ActionResult<FreelancersResponse>> GetFreelancers(int id)
    {
        var freelancers = await _repository.GetFreelancersAsync(id);
        return freelancers.MapFreelancers();
    }

    [Route("domains/{domainId}/freelancers/{freelancerId}")]
    [HttpGet]
    public async Task<ActionResult<FreelancerResponse>> GetFreelancerById(
        int domainId, int freelancerId)
    {
        var freelancer = await _repository.GetFreelancerByIdAsync(domainId, freelancerId);
        return freelancer.MapFreelancer();
    }

    [Route("freelancers")]
    [HttpGet]
    public async Task<ActionResult<FreelancersResponse>> GetAllFreelancers()
    {
        var freelancers = await _repository.GetAllFreelancersAsync();
        return freelancers.MapFreelancers();
    }

    [Route("expertises/{below}/{above}")]
    [HttpGet]
    public async Task<ActionResult<ExpertisesResponse>> GetSomeExpertises(int below, int above)
    {
        var expertises = await _repository.GetSomeExpertisesAsync(below, above);
        return expertises.MapExpertises();
    }
}