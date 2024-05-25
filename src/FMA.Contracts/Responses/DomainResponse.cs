using fm.Contracts.Responses;

public class DomainResponse
{
    public required Guid Id { get; set; }

    public required string DomainName { get; set; }

    public required string PhotoPath { get; set; }
    public required string FontFamily { get; set; }

    public required IEnumerable<FreelancerResponse> Freelancers { get; set; } = Enumerable.Empty<FreelancerResponse>();

    public int FreelancerCount => Freelancers.Count();
};