namespace FMA.Contracts.Responses;

public class ExpertisesResponse
{
    public IEnumerable<ExpertiseResponse> Expertises { get; set; } = Enumerable.Empty<ExpertiseResponse>();

}