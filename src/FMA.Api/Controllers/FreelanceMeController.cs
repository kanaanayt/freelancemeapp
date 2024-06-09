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
        var freelancers = (await _repository.GetFreelancersAsync(id)).ToList();
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
        var freelancers = (await _repository.GetAllFreelancersAsync()).ToList();
        return freelancers.MapFreelancers();
    }

    [Route("images/expertise/{id}")]
    [HttpGet]
    public async Task<IActionResult> GetExpertisePhoto(int id)
    {
        var expertise = await _repository.GetExpertiseAsync(id);
        Byte[] bytes = System.IO.File.ReadAllBytes(expertise.PhotoPath);
        return File(bytes, "image/jpeg");
    }

    [Route("images/domain/{id}")]
    [HttpGet]
    public async Task<IActionResult> GetDomainPhoto(int id)
    {
        var domain = await _repository.GetDomainAsync(id);
        Byte[] bytes = System.IO.File.ReadAllBytes(domain.PhotoPath);
        return File(bytes, "image/jpeg");
    }

    [HttpGet]
    [Route("expertises")]
    public async Task<ActionResult<ExpertisesResponse>> GetExpertises()
    {
        var expertises = await _repository.GetExpertisesAsync();
        return expertises.MapExpertises();
    }
}