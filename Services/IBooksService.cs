namespace BookStore.Services
{
    public interface IBooksService
    {
        //CRUD
        public IEnumerable<Book> GetAllBooks();

        public Book GetBookDetail(int id);
      
        public void Create(CreateBookFromViewModel book);

        public Book? Update(UpdateBookFromViewModel book);

        public bool Delete(int id);
        

        // Flexible filter
        IEnumerable<Book> GetFilteredBooks(BookFilterViewModel filter);


    }
}
