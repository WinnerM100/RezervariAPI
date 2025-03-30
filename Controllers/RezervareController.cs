
using Microsoft.AspNetCore.Mvc;
using RezervariAPI.Models;
using RezervariAPI.Services;

namespace RezervariAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class RezervareController : ControllerBase
{
    private IRezervareService rezervareService;

    public RezervareController(IRezervareService rezervareService)
    {
        this.rezervareService = rezervareService;
    }

    public IActionResult CreateRezervareForClient(DetaliiRezervare detaliiRezervare)
    {
        ConfirmareRezervare confirmareRezervare = rezervareService.CreateRezervareForClient(detaliiRezervare);

        if(confirmareRezervare == null)
        {
            return BadRequest($"Nu s-a putut crea nicio rezervare pentru detaliile: {detaliiRezervare}");
        }

        return Ok(confirmareRezervare);
    }
}