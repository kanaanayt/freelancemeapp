namespace FMA.Contracts.Responses;

public class FreelancersResponse
{
    public IEnumerable<FreelancerResponse> Freelancers { get; set; } = Enumerable.Empty<FreelancerResponse>();
};