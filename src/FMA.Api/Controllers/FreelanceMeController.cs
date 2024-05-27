using FMA.Api.Mappings;
using FMA.Application.Entities;
using FMA.Application.Repositories;
using Microsoft.AspNetCore.Mvc;
using FMA.Contracts.Responses;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace FMA.Api.Controllers
{
    [ApiController]
    // [Route("api/[controller]")]
    public class FreelanceMeController : ControllerBase
    {
        private readonly IFreelanceMeRepository _repository;
        public FreelanceMeController(IFreelanceMeRepository repository)
        {
            _repository = repository;
        }
        [Route("api/domains")]
        [HttpGet]
        public async Task<ActionResult<DomainsResponse>> GetDomains()
        {
            var entities = await _repository.GetDomainsAsync();
            return entities.MapDomains();
        }

        [Route("api/domains/{id}")]
        [HttpGet]
        public async Task<ActionResult<DomainResponse>> GetDomain(int id)
        {
            var entity = await _repository.GetDomainAsync(id);
            return entity.MapDomain();
        }

        [Route("api/domains/{id}/freelancers")]
        [HttpGet]
        public async Task<ActionResult<FreelancersResponse>> GetFreelancers(int id)
        {
            var freelancers = await _repository.GetFreelancersAsync(id);
            return freelancers.MapFreelancers();
        }

        [Route("api/domains/{domainId}/freelancers/{freelancerId}")]
        [HttpGet]
        public async Task<ActionResult<FreelancerResponse>> GetFreelancerById(
            int domainId, int freelancerId)
        {
            var freelancer = await _repository.GetFreelancerByIdAsync(domainId, freelancerId);
            return freelancer.MapFreelancer();
        }
    }
}