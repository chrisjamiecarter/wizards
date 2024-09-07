using Microsoft.AspNetCore.Mvc;
using Wizards.Api.Models;

namespace Wizards.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WizardsController : ControllerBase
{
    private static readonly Wizard[] _wizards =
    [
        new Wizard
        {
            Id = Guid.NewGuid(),
            Name = "Harry Potter",
            ImageUrl = "TBC",
            Universe = "Harry Potter"
        },
        new Wizard
        {
            Id = Guid.NewGuid(),
            Name = "Gandalf",
            ImageUrl = "TBC",
            Universe = "Lord of the Rings"
        }
    ];

    [HttpGet]
    public IEnumerable<Wizard> Get()
    {
        return _wizards;
    }
}
