namespace FMA.Contracts.Responses;

public class ExpertiseResponse 
{
    public required int Id { get; set; }

    public required string ExpertiseName { get; set; }

    public required FreelancersResponse Freelancers { get; set; }

    public int ExpertiseCount => Freelancers.Items. Count();
}
 