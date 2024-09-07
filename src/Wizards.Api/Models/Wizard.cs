namespace Wizards.Api.Models;

public class Wizard
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public string? Universe { get; set; }

    public string? ImageUrl { get; set; }
}
