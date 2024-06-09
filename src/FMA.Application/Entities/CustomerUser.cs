namespace FMA.Application.Entities;

public class CustomerUser
{
    public required Guid Id { get; set; }
    public required string Username { get; set; }
    public required string Password { get; set; }
    public required string Latitude { get; set; }
    public required string Longitude { get; set; }
    public required string PhoneNumber { get; set; }
    public required string TotalHires { get; set; }
}
