namespace Envy.API.DTO;

public class DeckWithRelationDTO
{
    public Guid Id { get; init; }
    
    public DateTime CreatedDate { get; init; }

    public DateTime UpdatedDate { get; init; }

    public string Title { get; init; }

    public IEnumerable<CardDTO> Cards { get; init; }

    public int CardsCount { get; init; }
}