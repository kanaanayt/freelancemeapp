using FMA.Api.Mappings;
using FMA.Application.Entities;
using FMA.Application.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FMA.Api.Controllers
{
    [ApiController]
    // [Route("api/[controller]")]
    public class FreelancerController : ControllerBase
    {
        private readonly IFreelanceMeRepository _repository;
        public FreelancerController(IFreelanceMeRepository repository)
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
    }
}