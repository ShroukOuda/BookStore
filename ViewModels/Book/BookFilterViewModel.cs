public class BookFilterViewModel
{
 
    public int? CategoryId { get; set; }
    public int? AuthorId { get; set; }
    public string? Language { get; set; }
    public decimal? MinPrice { get; set; }
    public decimal? MaxPrice { get; set; }
    public int? MinPages { get; set; }
    public int? MaxPages { get; set; }
    public string SearchQuery { get; set; }
    
    public IEnumerable<Book> Books { get; set; } = new List<Book>();

    
    public IEnumerable<Category> Categories { get; set; } = new List<Category>();
    public IEnumerable<Author> Authors { get; set; } = new List<Author>();
    

}