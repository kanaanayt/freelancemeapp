namespace FMA.Contracts.Responses;

public class FreelancersResponse
{
    public IEnumerable<FreelancerResponse> Items { get; set; } = Enumerable.Empty<FreelancerResponse>();
};