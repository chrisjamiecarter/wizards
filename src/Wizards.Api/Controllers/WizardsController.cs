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
            Description = "A wizard from the Harry Potter universe."
        },
        new Wizard
        {
            Id = Guid.NewGuid(),
            Name = "Gandalf",
            ImageUrl = "TBC",
            Description = "A wizard from the Lord of the Rings universe."
        }
    ];

    [HttpGet("get")]
    public IEnumerable<Wizard> Get()
    {
        return _wizards;
    }

    [HttpGet("get/{id}")]
    public Wizard? Get(Guid id)
    {
        return _wizards.FirstOrDefault(x => x.Id == id);
    }
}
