using Microsoft.EntityFrameworkCore;
using Wizards.Api.Models;

namespace Wizards.Api.Data;

public class WizardsDataContext : DbContext
{
    #region Constructors

    public WizardsDataContext (DbContextOptions<WizardsDataContext> options) : base(options)
    {
    }

    #endregion
    #region Properties

    public DbSet<Wizard> Wizard { get; set; }

    #endregion
}
