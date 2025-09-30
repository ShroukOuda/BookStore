namespace BookStore.ViewModels.Book;

public class UpdateBookFromViewModel : BookFromViewModel
{
    public int Id { get; set; }
    public string? CurrentImage { get; set; }
    
    [AllowedExtensions(FileSettings.AllowedExtensions)]
    [MaxFileSize(FileSettings.MaxFileSizeInBytes)]
    public IFormFile? ImageUrl { get; set; }

}