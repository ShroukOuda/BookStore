namespace BookStore.ViewModels.Category;

public class CategoryFormViewModel
{
    public int Id { get; set; }
    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    public string Description { get; set; }
    
}