namespace BookStore.Models
{
    public class BookAuthor
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int AuthorId { get; set; }

        //Navigation Properties
        public Book Book { get; set; }
        public Author Author { get; set; }
    }
}
