namespace fm.Contracts.Responses;

public record FreelancersReponse
{
    public IEnumerable<FreelancerResponse> Items { get; set; } = Enumerable.Empty<FreelancerResponse>();
};