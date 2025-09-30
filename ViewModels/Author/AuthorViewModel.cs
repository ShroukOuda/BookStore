namespace BookStore.ViewModels.Author;

public class AuthorViewModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Biography { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public int BookCount { get; set; }
}