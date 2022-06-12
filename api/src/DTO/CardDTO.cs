namespace Envy.API.DTO;

public class CardDTO
{
    public Guid Id { get; init; }
    
    public DateTime CreatedDate { get; init; }

    public DateTime UpdatedDate { get; init; }

    public List<string> Sides { get; init; }
}