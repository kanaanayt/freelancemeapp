namespace FMA.Contracts.Responses;

public class DomainsResponse
{
    public IEnumerable<DomainResponse> Items { get; set; } = Enumerable.Empty<DomainResponse>();
};