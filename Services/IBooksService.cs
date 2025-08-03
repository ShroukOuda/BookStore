namespace BookStore.Services
{
    public interface IBooksService
    {
        public IEnumerable<Book> GetAllBooks();

        public Book GetBookDetail(int id);
        public void Create(CreateBookFromViewModel book);

       
    }
}
