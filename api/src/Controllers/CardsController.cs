namespace Envy.API.Controllers;

using Envy.API.DTO;
using Envy.API.Entities;
using Envy.API.Extensions;
using Envy.API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

[ApiController]
[Route("api/[controller]")]
public class CardsController : ControllerBase
{
    public ILogger<CardsController> Logger { get; }

    public ICardRepository Repository { get; }

    public CardsController(
        ILogger<CardsController> logger,
        ICardRepository repository
        )
    {
        Logger = logger;
        Repository = repository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<CardDTO>>> GetAllCards()
    {
        IEnumerable<Card> cards = await Repository.GetAllCardsAsync();

        if (!cards.Any())
            return NotFound();

        IEnumerable<CardDTO> DTOs = cards.Select(x => x.AsCardDTO());

        return Ok(DTOs);
    }

    [HttpGet("related")]
    public async Task<ActionResult<IEnumerable<CardWithRelationDTO>>> GetAllCardsWithRelation()
    {
        IEnumerable<Card> cards = await Repository.GetAllCardsWithRelationAsync();

        if (!cards.Any())
            return NotFound();

        IEnumerable<CardWithRelationDTO> DTOs = cards.Select(x => x.AsCardWithRelationDTO());

        return Ok(DTOs);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<CardDTO>> GetCard(Guid id)
    {
        Card card = await Repository.GetCardAsync(id);

        if (card == null)
            return NotFound();
        
        return Ok(card);
    }

    [HttpGet("from/{deckId}")]
    public async Task<ActionResult<IEnumerable<CardDTO>>> GetCardsFromDeck(Guid deckId)
    {
        IEnumerable<Card> cards = await Repository.GetCardsFromDeckAsync(deckId);

        if (cards == null) 
            return NotFound();

        IEnumerable<CardDTO> DTOs = cards.Select(x => x.AsCardDTO());

        return Ok(DTOs);
    }
}
