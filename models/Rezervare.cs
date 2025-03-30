
namespace RezervariAPI.Models;

public class Rezervare
{
    public Guid Id { get; init; }

    public string RezervareNumber { get; init; }

    public Guid ClientId { get; init; }

    public string Contact1 { get; set; }
    public string Contact2 { get; set; }

    public string NrPersoane { get; set; }

    public DateTime Data { get; set; }

    public string Comentarii { get; set; }
}