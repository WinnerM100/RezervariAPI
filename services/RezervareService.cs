

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RezervariAPI.Models;

namespace RezervariAPI.Services;

public class RezervariService : IRezervareService
{
    private DbContext dbContext;

    public RezervariService(DbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public ConfirmareRezervare CreateRezervareForClient(DetaliiRezervare detaliiRezervare)
    {
        Rezervare newRezervare = new Rezervare()
        {
            Id = Guid.NewGuid(),
            ClientId = detaliiRezervare.ClientId,
            Comentarii = detaliiRezervare.Comentarii,
            Data = detaliiRezervare.Data,
            NrPersoane = detaliiRezervare.NrPersoane,
            NrTelefon = detaliiRezervare.NrTelefon,
            RezervareNumber = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()
        };

        dbContext.Add(newRezervare);
        dbContext.SaveChanges();
        
        return new ConfirmareRezervare()
        {
            ClientId = newRezervare.ClientId,
            Id = newRezervare.Id,
            RezervareNumber = newRezervare.RezervareNumber
        };
    }
}
