using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Wizards.Api.Data;
using Wizards.Api.Models;

namespace Wizards.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class WizardsController : ControllerBase
{
    #region Fields

    private readonly WizardsDataContext _context;

    #endregion
    #region Constructors

    public WizardsController(WizardsDataContext context)
    {
        _context = context;
    }

    #endregion
    #region Methods

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Wizard>>> GetWizard()
    {
        return await _context.Wizard.OrderBy(o => o.Name).ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Wizard>> GetWizard(Guid id)
    {
        var wizard = await _context.Wizard.FindAsync(id);

        return wizard == null 
            ? NotFound() 
            : wizard;
    }

    #endregion
}
