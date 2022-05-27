namespace Envy.API.Entities;

public class Deck
{
    public Guid? Id { get; set; } = Guid.NewGuid();
    
    public DateTime CreatedDate { get; set; } = DateTime.Now.ToUniversalTime();

    public DateTime UpdatedDate { get; set; } = DateTime.Now.ToUniversalTime();

    public string Title { get; set; }

    public List<Card> Cards { get; set; } = new();

    public int CardsCount { get; set; }
}