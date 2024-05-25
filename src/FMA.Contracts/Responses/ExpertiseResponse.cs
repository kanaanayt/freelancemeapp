namespace fm.Contracts.Responses;

public class ExpertiseResponse 
{
    public required Guid Id { get; set; }

    public required string Name { get; set; }

    public required IEnumerable<FreelancerResponse> Freelancers { get; set; } = Enumerable.Empty<FreelancerResponse>();

    public int ExpertiseCount => Freelancers.Count();
}
