namespace MarkdownNotesApp.Models;

public class Note
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;   
    public string Content { get; set; } = string.Empty;
    public string HtmlContent { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}
