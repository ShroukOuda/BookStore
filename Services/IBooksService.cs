namespace BookStore.Services
{
    public interface IBooksService
    {
        public IEnumerable<Book> GetAllBooks();
        public void Create(CreateBookFromViewModel book);

       
    }
}
