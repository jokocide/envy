namespace Envy.API.Entities;

public class Card
{
    public Guid Id { get; set; }  = Guid.NewGuid();
    
    public DateTime CreatedDate { get; set; } = DateTime.Now.ToUniversalTime();

    public DateTime UpdatedDate { get; set; } = DateTime.Now.ToUniversalTime();

    public string Question { get; set; }

    public string Answer { get; set; }
    
    public Guid DeckId { get; set; }
    
    public Deck Deck { get; set; }
}