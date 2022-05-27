namespace Envy.API.DTO;

public class DeckDTO
{
    public Guid Id { get; init; }
    
    public DateTime CreatedDate { get; init; }

    public DateTime UpdatedDate { get; init; }

    public string Title { get; init; }

    public int CardsCount { get; init; }
}