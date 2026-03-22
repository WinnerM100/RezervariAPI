
namespace RezervariAPI.Models.DAOs;
public class ConfirmareRezervare
{
    public Guid Id { get; init; }
    
    public required string RezervareNumber { get; init; }

    public Guid ClientId { get; init; }
}