namespace fm.Contracts.Responses;

public record FreelancerResponse 
{
    public required Guid Id { get; set; }

    public required Guid DomainId { get; set; }

    public required IEnumerable<ExpertiseResponse> Expertises { get; set; } = Enumerable.Empty<ExpertiseResponse>();

    public int NumberOfSkills => Expertises.Count();

    public required int HoursBilled { get; set; }

    public required string FirstName { get; set; }
    public required string LastName { get; set; }

    public required DateTime DateRegistered { get; set; }

    public required string PhotoPath { get; set; }
    public required string Email { get; set; }

    public required string PhoneNumber { get; set; }

    public required decimal HourlyRate { get; set; }
    public required decimal Rating { get; set; }
    public required int FulfilledContracts { get; set; }

    public required decimal Latitude { get; set; }
    public required decimal Longitude { get; set; }

    public required bool IsActive { get; set; }
};
