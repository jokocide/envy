namespace Envy.API.Controllers;

using Envy.API.DTO;
using Envy.API.Entities;
using Envy.API.Extensions;
using Envy.API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

[ApiController]
[Route("api/[controller]")]
public class DecksController : ControllerBase
{
    public ILogger<DecksController> Logger { get; }

    public IDeckRepository Repository { get; }

    public DecksController(
        ILogger<DecksController> logger,
        IDeckRepository repository
        )
    {
        Logger = logger;
        Repository = repository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<DeckDTO>>> GetAllDecks()
    {
        IEnumerable<Deck> decks = await Repository.GetAllDecksAsync();
        return Ok(decks.AsDeckDTO());
    }

    [HttpGet("related")]
    public async Task<ActionResult<IEnumerable<DeckDTO>>> GetAllDecksWithRelation()
    {
        IEnumerable<Deck> decks = await Repository.GetAllDecksWithRelationAsync();
        return Ok(decks.AsDeckWithRelationDTO());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<DeckDTO>> GetDeck(Guid id)
    {
        Deck deck = await Repository.GetDeckAsync(id);

        if (deck == null)
            return NotFound();

        return Ok(deck.AsDeckDTO());
    }

    [HttpGet("related/{id}")]
    public async Task<ActionResult<DeckWithRelationDTO>> GetDeckWithRelation(Guid id)
    {
        Deck deck = await Repository.GetDeckWithRelationAsync(id);

        if (deck == null)
            return NotFound();

        return Ok(deck.AsDeckWithRelationDTO());
    }
}
