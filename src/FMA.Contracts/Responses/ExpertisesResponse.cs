namespace FMA.Contracts.Responses;

public class ExpertisesResponse
{
    public IEnumerable<ExpertiseResponse> Items { get; set; } = Enumerable.Empty<ExpertiseResponse>();

}