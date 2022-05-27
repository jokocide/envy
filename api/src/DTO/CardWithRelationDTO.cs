namespace Envy.API.DTO;

public class CardWithRelationDTO
{
    public Guid Id { get; init; }
    
    public DateTime CreatedDate { get; init; }

    public DateTime UpdatedDate { get; init; }

    public string Question { get; init; }

    public string Answer { get; init; }
    
    public DeckDTO Deck { get; init; }
}