namespace Envy.API.Entities;

public class Note
{
    public Guid? Id { get; set; } = Guid.NewGuid();
    
    public DateTime CreatedDate { get; set; } = DateTime.Now.ToUniversalTime();

    public DateTime UpdatedDate { get; set; } = DateTime.Now.ToUniversalTime();

    public string Title { get; set; }

    public string Body { get; set; }

    public Guid CardId { get; set; }

    public Card Card { get; set; }

    public List<Link> Links { get; set; } = new();
}