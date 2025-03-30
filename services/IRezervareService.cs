

using Microsoft.AspNetCore.Mvc;
using RezervariAPI.Models;

namespace RezervariAPI.Services;

public interface IRezervareService
{
    public ConfirmareRezervare CreateRezervareForClient(DetaliiRezervare detaliiRezervare);
}