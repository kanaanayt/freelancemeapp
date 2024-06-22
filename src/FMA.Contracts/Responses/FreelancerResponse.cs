namespace FMA.Contracts.Responses;

public class FreelancerResponse 
{
    public required int Id { get; set; }

    public required int DomainId { get; set; }

    public ExpertiseResponse Expertise { get; set; }
    public List<string> OtherExpertises { get; set; } = new();

    public int NumberOfSkills => OtherExpertises.Count();

    public required int HoursBilled { get; set; }

    public required string FirstName { get; set; }
    public required string LastName { get; set; }

    public required DateTime DateRegistered { get; set; }

    public required string PhotoPath { get; set; }
    public required string Email { get; set; }

    public required string PhoneNumber { get; set; }

    public required double HourlyRate { get; set; }
    public required double Rating { get; set; }
    public required int FulfilledContracts { get; set; }

    public required double Latitude { get; set; }
    public required double Longitude { get; set; }

    public required bool IsActive { get; set; }
};
