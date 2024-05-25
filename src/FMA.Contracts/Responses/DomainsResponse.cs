using fm.Contracts.Responses;

public class DomainsResponse
{
    public IEnumerable<DomainResponse> Domains { get; set; } = Enumerable.Empty<DomainResponse>();
};