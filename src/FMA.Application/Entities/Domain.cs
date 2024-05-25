using System.Collections.ObjectModel;

namespace FMA.Application.Entities;

public class Domain
{
    public required int Id { get; set; }

    public required string DomainName { get; set; }

    public required string PhotoPath { get; set; }
    public required string FontFamily { get; set; }

    public ICollection<Freelancer> Freelancers { get; set; }  = new Collection<Freelancer>();
    public ICollection<Expertise> Expertises { get; set; } = new Collection<Expertise>();
};
