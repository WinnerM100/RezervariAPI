

using Microsoft.AspNetCore.Mvc;
using RezervariAPI.Models;
using RezervariAPI.Models.DAOs;
using RezervariAPI.Models.DTOs;

namespace RezervariAPI.Services;

public interface IRezervariService
{
    public ConfirmareRezervare CreateRezervareForClient(DetaliiRezervare detaliiRezervare);
}