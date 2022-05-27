namespace Envy.API.Interfaces;

using Envy.API.Entities;

public interface IDeckRepository
{
    Task<IEnumerable<Deck>> GetAllDecksAsync();

    Task<IEnumerable<Deck>> GetAllDecksWithRelationAsync();

    Task<Deck> GetDeckAsync(Guid id);

    Task<Deck> GetDeckWithRelationAsync(Guid id);

    Task CreateDeckAsync(Deck deck);
}