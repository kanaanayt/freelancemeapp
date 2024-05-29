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
    // Landing page
    public async Task<ActionResult<DomainsResponse>> GetDomains()
    {
        var entities = await _repository.GetDomainsAsync();
        return entities.MapDomains();
    }

    [Route("domains/{id}")]
    [HttpGet]
    // Title of domain page. Its font, perhaps the photo. And number of frelancers
    public async Task<ActionResult<DomainResponse>> GetDomain(int id)
    {
        var entity = await _repository.GetDomainAsync(id);
        return entity.MapDomain();
    }

    // Get Freelancers under specific domain. All of them. Before expertise filtering
    [Route("domains/{id}/freelancers")]
    [HttpGet]
    public async Task<ActionResult<FreelancersResponse>> GetFreelancers(int id)
    {
        var freelancers = await _repository.GetFreelancersAsync(id);
        return freelancers.MapFreelancers();
    }

    // View freelancer page, contact me button
    [Route("domains/{domainId}/freelancers/{freelancerId}")]
    [HttpGet]
    public async Task<ActionResult<FreelancerResponse>> GetFreelancerById(
        int domainId, int freelancerId)
    {
        var freelancer = await _repository.GetFreelancerByIdAsync(domainId, freelancerId);
        return freelancer.MapFreelancer();
    }

    // Filter by name, expertise page
    [Route("freelancers")]
    [HttpGet]
    public async Task<ActionResult<FreelancersResponse>> GetAllFreelancers()
    {
        var freelancers = await _repository.GetAllFreelancersAsync();
        return freelancers.MapFreelancers();
    }

    // Expertise mini filtering under single domain
    [Route("domain/{domainId}/expertises/{below}/{above}")]
    [HttpGet]
    public async Task<ActionResult<ExpertisesResponse>> GetSomeExpertises(
        int domainId, int below, int above)
    {
        var expertises = await _repository.GetSomeExpertisesAsync(domainId, below, above);
        return expertises.MapExpertises();
    }
}