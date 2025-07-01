namespace BookStore.Data.Seed
{
    public class BookAuthorSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuthor>().HasData(
                new BookAuthor { BookId = 1, AuthorId = 1 },
                new BookAuthor { BookId = 2, AuthorId = 2 },
                new BookAuthor { BookId = 3, AuthorId = 3 },
                new BookAuthor { BookId = 4, AuthorId = 4 },
                new BookAuthor { BookId = 5, AuthorId = 5 },
                new BookAuthor { BookId = 5, AuthorId = 6 },
                new BookAuthor { BookId = 6, AuthorId = 7 },
                new BookAuthor { BookId = 6, AuthorId = 8 },
                new BookAuthor { BookId = 7, AuthorId = 2 },
                new BookAuthor { BookId = 8, AuthorId = 3 },
                new BookAuthor { BookId = 9, AuthorId = 4 },
                new BookAuthor { BookId = 10, AuthorId = 10 },
                new BookAuthor { BookId = 11, AuthorId = 9 },
                new BookAuthor { BookId = 12, AuthorId = 7 }
            );
        }
    }
}

