namespace Envy.API.Entities;

public class Link
{
    public Guid? Id { get; set; } = Guid.NewGuid();
    
    public DateTime CreatedDate { get; set; } = DateTime.Now.ToUniversalTime();

    public DateTime UpdatedDate { get; set; } = DateTime.Now.ToUniversalTime();

    public string URL { get; set; }

    public Guid NoteId { get; set; }

    public Note Note { get; set; }
}