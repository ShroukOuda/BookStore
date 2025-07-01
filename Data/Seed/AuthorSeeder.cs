namespace BookStore.Data.Seed
{
    public class AuthorSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                 new Author
                 {
                     Id = 1,
                     FirstName = "Robert",
                     LastName = "Martin",
                     Biography = "Software engineer and author, also known as Uncle Bob. Known for advocating software design principles and clean code practices.",
                     BirthDate = new DateTime(1952, 12, 5),
                     Nationality = "American",
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow
                 },
                new Author
                {
                    Id = 2,
                    FirstName = "Jon",
                    LastName = "Duckett",
                    Biography = "Web designer and developer who has spent over a decade helping people learn about web design and programming.",
                    BirthDate = new DateTime(1970, 3, 15),
                    Nationality = "British",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Author
                {
                    Id = 3,
                    FirstName = "Kyle",
                    LastName = "Simpson",
                    Biography = "JavaScript developer and trainer, known for the You Don't Know JS book series and open source contributions.",
                    BirthDate = new DateTime(1980, 7, 12),
                    Nationality = "American",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Author
                {
                    Id = 4,
                    FirstName = "Gayle",
                    LastName = "McDowell",
                    Biography = "Software engineer and author, former Google, Microsoft, and Apple employee. Founder of CareerCup.",
                    BirthDate = new DateTime(1982, 9, 20),
                    Nationality = "American",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Author
                {
                    Id = 5,
                    FirstName = "Andrew",
                    LastName = "Hunt",
                    Biography = "Software developer and author, co-author of The Pragmatic Programmer and founding member of the Agile Alliance.",
                    BirthDate = new DateTime(1964, 8, 3),
                    Nationality = "American",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Author
                {
                    Id = 6,
                    FirstName = "David",
                    LastName = "Thomas",
                    Biography = "Software developer and author, co-author of The Pragmatic Programmer and advocate for pragmatic software development.",
                    BirthDate = new DateTime(1956, 11, 28),
                    Nationality = "British",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Author
                {
                    Id = 7,
                    FirstName = "Eric",
                    LastName = "Freeman",
                    Biography = "Computer scientist, author, and former CTO of Disney Online, known for Head First book series.",
                    BirthDate = new DateTime(1965, 4, 18),
                    Nationality = "American",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Author
                {
                    Id = 8,
                    FirstName = "Elisabeth",
                    LastName = "Robson",
                    Biography = "Software developer and co-author of several Head First books, specializing in web development and programming education.",
                    BirthDate = new DateTime(1970, 2, 14),
                    Nationality = "American",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Author
                {
                    Id = 9,
                    FirstName = "Martin",
                    LastName = "Fowler",
                    Biography = "British software developer, author and international speaker on software development, known for refactoring and enterprise software design.",
                    BirthDate = new DateTime(1963, 12, 18),
                    Nationality = "British",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Author
                {
                    Id = 10,
                    FirstName = "Gene",
                    LastName = "Kim",
                    Biography = "Multi-award winning CTO, researcher and author, known for The Phoenix Project and The DevOps Handbook.",
                    BirthDate = new DateTime(1967, 10, 8),
                    Nationality = "American",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                }
            );
        }
    }
}
