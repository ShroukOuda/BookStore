
namespace BookStore.ViewModels.Book
{
    public class CreateBookFromViewModel : BookFromViewModel
    {
	    [AllowedExtensions(FileSettings.AllowedExtensions)]
	    [MaxFileSize(FileSettings.MaxFileSizeInBytes)]
	    public IFormFile ImageUrl { get; set; }
	}
}
