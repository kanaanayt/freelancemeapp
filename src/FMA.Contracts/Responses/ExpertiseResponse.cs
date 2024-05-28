namespace FMA.Contracts.Responses;

public class ExpertiseResponse 
{
    public required Guid Id { get; set; }

    public required string Name { get; set; }

    public required FreelancersResponse Freelancers { get; set; }

    public int ExpertiseCount => Freelancers.Items. Count();
}
 