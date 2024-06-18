namespace FMA.Contracts.Requests;

public class FreelancerRequest
{
    public string Name { get; set; }
    public string ExpertiseName { get; set; }
    public string Email { get; set; }
    public decimal MaxHourlyRate { get; set; }
    public decimal MinRating { get; set; }
    public decimal MaxDistance { get; set; }
}