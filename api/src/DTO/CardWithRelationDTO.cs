namespace Envy.API.DTO;

public class CardWithRelationDTO
{
    public Guid Id { get; init; }
    
    public DateTime CreatedDate { get; init; }

    public DateTime UpdatedDate { get; init; }

    public List<string> Sides { get; init; }
    
    public DeckDTO Deck { get; init; }
}