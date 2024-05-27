using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace FMA.Application.Entities;

public class Freelancer
{
    public required int Id { get; set; }

    public required int DomainId { get; set; }
    [ForeignKey("DomainId")]
    public Domain? Domain { get; set; }

    // public int ExpertiseId { get; set; }
    //public ICollection<FreelancerExpertise> FreelancerExpertise { get; set; } = new Collection<FreelancerExpertise>();
    public ICollection<Expertise> Expertises { get; set; } = new Collection<Expertise>();
    [NotMapped] public Expertise? Expertise { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }

    public required DateTime DateRegistered { get; set; }

    public required string PhotoPath { get; set; }
    public required string Email { get; set; }

    public required string PhoneNumber { get; set; }

    public required decimal HourlyRate { get; set; }
    public required decimal Rating { get; set; }
    public required int FulfilledContracts { get; set; }
    public required int HoursBilled { get; set; }

    public required decimal Latitude { get; set; }
    public required decimal Longitude { get; set; }

    public required bool IsActive { get; set; }
}