namespace Envy.API.Interfaces;

using Envy.API.Entities;

public interface ICardRepository
{
    Task<IEnumerable<Card>> GetAllCardsAsync();

    Task<IEnumerable<Card>> GetAllCardsWithRelationAsync();

    Task<Card> GetCardAsync(Guid id);

    Task<IEnumerable<Card>> GetCardsFromDeckAsync(Guid id);

    Task CreateCardAsync(Card card);
}