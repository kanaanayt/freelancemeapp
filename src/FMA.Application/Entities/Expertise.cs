using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace FMA.Application.Entities;

public class Expertise
{
    public required int Id { get; set; }

    public required int DomainId { get; set; }
    [ForeignKey("DomainId")]
    public  Domain? Domain { get; set; }

    public required string ExpertiseName { get; set; }

    public ICollection<Freelancer> Freelancers { get; set; } = new Collection<Freelancer>();
}
