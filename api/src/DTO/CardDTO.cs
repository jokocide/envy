namespace Envy.API.DTO;

public class CardDTO
{
    public Guid Id { get; init; }
    
    public DateTime CreatedDate { get; init; }

    public DateTime UpdatedDate { get; init; }

    public string Question { get; init; }

    public string Answer { get; init; }
}