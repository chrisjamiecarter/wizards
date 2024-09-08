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
            ImageUrl = "TBC: link to hosted image",
            Description = "A wizard from the Harry Potter universe."
        },
        new Wizard
        {
            Id = Guid.NewGuid(),
            Name = "Gandalf the Grey",
            ImageUrl = "TBC: link to hosted image",
            Description = "A wizard from the Lord of the Rings universe, known for his wisdom and power."
        },
        new Wizard
        {
            Id = Guid.NewGuid(),
            Name = "Merlin",
            ImageUrl = "TBC: link to hosted image",
            Description = "A legendary wizard from Arthurian mythology, often depicted as King Arthur's advisor."
        },
        new Wizard
        {
            Id = Guid.NewGuid(),
            Name = "Albus Dumbledore",
            ImageUrl = "TBC: link to hosted image",
            Description = "The headmaster of Hogwarts and one of the greatest wizards in the Harry Potter universe."
        },
        new Wizard
        {
            Id = Guid.NewGuid(),
            Name = "Doctor Strange",
            ImageUrl = "TBC: link to hosted image",
            Description = "A master of the mystic arts from the Marvel universe."
        },
        new Wizard
        {
            Id = Guid.NewGuid(),
            Name = "Saruman",
            ImageUrl = "TBC: link to hosted image",
            Description = "A powerful and once-wise wizard who turned to evil in the Lord of the Rings universe."
        },
        new Wizard
        {
            Id = Guid.NewGuid(),
            Name = "Morgana Le Fay",
            ImageUrl = "TBC: link to hosted image",
            Description = "A powerful sorceress from Arthurian legend, often depicted as an antagonist to Merlin."
        },
        new Wizard
        {
            Id = Guid.NewGuid(),
            Name = "Rincewind",
            ImageUrl = "TBC: link to hosted image",
            Description = "A bumbling wizard from Terry Pratchett's Discworld series."
        },
        new Wizard
        {
            Id = Guid.NewGuid(),
            Name = "Elminster Aumar",
            ImageUrl = "TBC: link to hosted image",
            Description = "A legendary wizard from the Forgotten Realms universe, created by Dungeons & Dragons."
        },
        new Wizard
        {
            Id = Guid.NewGuid(),
            Name = "Raistlin Majere",
            ImageUrl = "TBC: link to hosted image",
            Description = "A dark wizard from the Dragonlance universe, known for his immense power and ambition."
        },
        new Wizard
        {
            Id = Guid.NewGuid(),
            Name = "The Wizard of Oz",
            ImageUrl = "TBC: link to hosted image",
            Description = "The mysterious and supposedly all-powerful wizard from the Land of Oz."
        },
        new Wizard
        {
            Id = Guid.NewGuid(),
            Name = "Zatanna Zatara",
            ImageUrl = "TBC: link to hosted image",
            Description = "A magician and superhero from DC Comics who casts spells by speaking backwards."
        },
        new Wizard
        {
            Id = Guid.NewGuid(),
            Name = "Prospero",
            ImageUrl = "TBC: link to hosted image",
            Description = "The protagonist of Shakespeare's play 'The Tempest', known for his magical abilities."
        },
        new Wizard
        {
            Id = Guid.NewGuid(),
            Name = "Mordenkainen",
            ImageUrl = "TBC: link to hosted image",
            Description = "A powerful wizard from Dungeons & Dragons lore, known for his neutrality and mastery of magic."
        },
        new Wizard
        {
            Id = Guid.NewGuid(),
            Name = "Tim the Enchanter",
            ImageUrl = "TBC: link to hosted image",
            Description = "A comedic wizard from Monty Python and the Holy Grail."
        },
        new Wizard
        {
            Id = Guid.NewGuid(),
            Name = "Jafar",
            ImageUrl = "TBC: link to hosted image",
            Description = "The royal vizier and sorcerer from Disney's Aladdin."
        },
        new Wizard
        {
            Id = Guid.NewGuid(),
            Name = "The Ancient One",
            ImageUrl = "TBC: link to hosted image",
            Description = "The mentor of Doctor Strange and the previous Sorcerer Supreme in the Marvel universe."
        },
        new Wizard
        {
            Id = Guid.NewGuid(),
            Name = "Orko",
            ImageUrl = "TBC: link to hosted image",
            Description = "A clumsy yet lovable wizard from the Masters of the Universe series."
        },
        new Wizard
        {
            Id = Guid.NewGuid(),
            Name = "Ged (Sparrowhawk)",
            ImageUrl = "TBC: link to hosted image",
            Description = "The protagonist of Ursula K. Le Guin's Earthsea series, a powerful mage."
        },
        new Wizard
        {
            Id = Guid.NewGuid(),
            Name = "Yennefer of Vengerberg",
            ImageUrl = "TBC: link to hosted image",
            Description = "A sorceress from The Witcher universe, known for her intelligence and magical prowess."
        },
        new Wizard
        {
            Id = Guid.NewGuid(),
            Name = "Karsus",
            ImageUrl = "TBC: link to hosted image",
            Description = "A powerful wizard from the Forgotten Realms universe, known for his failed attempt to ascend to godhood."
        },
        new Wizard
        {
            Id = Guid.NewGuid(),
            Name = "Medivh",
            ImageUrl = "TBC: link to hosted image",
            Description = "A legendary wizard from the Warcraft universe, known as the Last Guardian."
        },
        new Wizard
        {
            Id = Guid.NewGuid(),
            Name = "Rita Repulsa",
            ImageUrl = "TBC: link to hosted image",
            Description = "An evil sorceress and villain from the Power Rangers series."
        },
        new Wizard
        {
            Id = Guid.NewGuid(),
            Name = "Wong",
            ImageUrl = "TBC: link to hosted image",
            Description = "The current Sorcerer Supreme and companion of Doctor Strange in the Marvel universe."
        },
        new Wizard
        {
            Id = Guid.NewGuid(),
            Name = "Voldemort",
            ImageUrl = "TBC: link to hosted image",
            Description = "The dark lord and antagonist from the Harry Potter universe, known for his quest for immortality."
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
