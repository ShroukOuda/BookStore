namespace BookStore.ViewModels.Category;

public class CategoryViewModel
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    public string Description { get; set; }

    public DateTime CreatedAt { get; set; } 
    
    public DateTime UpdatedAt { get; set; }
   
    public int BookCount { get; set; }
    
}