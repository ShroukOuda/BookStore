namespace BookStore.Data.Seed
{
    public class BookSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                 new Book
                 {
                     Id = 1,
                     Title = "Clean Code: A Handbook of Agile Software Craftsmanship",
                     ISBN = "9780132350884",
                     Price = 45.99m,
                     Description = "A handbook for writing clean, readable, and maintainable code with practical examples and best practices.",
                     StockQuantity = 50,
                     ImageUrl = "/images/books/clean-code.jpg",
                     PublishedDate = new DateTime(2008, 8, 1),
                     Pages = 464,
                     Language = "English",
                     CategoryId = 1,
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow
                 },
                new Book
                {
                    Id = 2,
                    Title = "HTML and CSS: Design and Build Websites",
                    ISBN = "9781118008188",
                    Price = 35.99m,
                    Description = "A full-color introduction to the basics of HTML and CSS for creating modern, professional websites.",
                    StockQuantity = 35,
                    ImageUrl = "/images/books/html-css.jpg",
                    PublishedDate = new DateTime(2011, 11, 8),
                    Pages = 490,
                    Language = "English",
                    CategoryId = 2,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Book
                {
                    Id = 3,
                    Title = "You Don't Know JS: Scope & Closures",
                    ISBN = "9781449335588",
                    Price = 29.99m,
                    Description = "Deep dive into JavaScript's scope and closures, essential concepts for mastering JavaScript.",
                    StockQuantity = 42,
                    ImageUrl = "/images/books/ydkjs-scope.jpg",
                    PublishedDate = new DateTime(2014, 3, 24),
                    Pages = 98,
                    Language = "English",
                    CategoryId = 2,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Book
                {
                    Id = 4,
                    Title = "Cracking the Coding Interview",
                    ISBN = "9780984782857",
                    Price = 39.99m,
                    Description = "189 programming questions and solutions to help you prepare for technical interviews at top tech companies.",
                    StockQuantity = 28,
                    ImageUrl = "/images/books/cracking-coding.jpg",
                    PublishedDate = new DateTime(2015, 7, 1),
                    Pages = 696,
                    Language = "English",
                    CategoryId = 1,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Book
                {
                    Id = 5,
                    Title = "The Pragmatic Programmer",
                    ISBN = "9780135957059",
                    Price = 49.99m,
                    Description = "Your journey to mastery - 20th Anniversary Edition with updated content for modern development practices.",
                    StockQuantity = 31,
                    ImageUrl = "/images/books/pragmatic-programmer.jpg",
                    PublishedDate = new DateTime(2019, 9, 13),
                    Pages = 352,
                    Language = "English",
                    CategoryId = 6,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Book
                {
                    Id = 6,
                    Title = "Head First Design Patterns",
                    ISBN = "9781492078005",
                    Price = 54.99m,
                    Description = "A brain-friendly guide to design patterns that every developer should know, with real-world examples.",
                    StockQuantity = 25,
                    ImageUrl = "/images/books/head-first-patterns.jpg",
                    PublishedDate = new DateTime(2020, 12, 10),
                    Pages = 672,
                    Language = "English",
                    CategoryId = 6,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Book
                {
                    Id = 7,
                    Title = "JavaScript: The Good Parts",
                    ISBN = "9780596517748",
                    Price = 34.99m,
                    Description = "Unearthing the excellence in JavaScript - a guide to the language's best features and how to use them effectively.",
                    StockQuantity = 45,
                    ImageUrl = "/images/books/js-good-parts.jpg",
                    PublishedDate = new DateTime(2008, 5, 1),
                    Pages = 176,
                    Language = "English",
                    CategoryId = 2,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Book
                {
                    Id = 8,
                    Title = "React Native in Action",
                    ISBN = "9781617294051",
                    Price = 44.99m,
                    Description = "Learn to build cross-platform mobile apps using React Native, from basic concepts to advanced techniques.",
                    StockQuantity = 22,
                    ImageUrl = "/images/books/react-native.jpg",
                    PublishedDate = new DateTime(2018, 3, 15),
                    Pages = 312,
                    Language = "English",
                    CategoryId = 3,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Book
                {
                    Id = 9,
                    Title = "Learning SQL",
                    ISBN = "9781492057611",
                    Price = 39.99m,
                    Description = "Master SQL fundamentals with this comprehensive guide covering queries, data manipulation, and database design.",
                    StockQuantity = 33,
                    ImageUrl = "/images/books/learning-sql.jpg",
                    PublishedDate = new DateTime(2020, 4, 27),
                    Pages = 370,
                    Language = "English",
                    CategoryId = 4,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Book
                {
                    Id = 10,
                    Title = "The Phoenix Project",
                    ISBN = "9781942788294",
                    Price = 42.99m,
                    Description = "A novel about IT, DevOps, and helping your business win - learn DevOps principles through an engaging story.",
                    StockQuantity = 27,
                    ImageUrl = "/images/books/phoenix-project.jpg",
                    PublishedDate = new DateTime(2018, 11, 26),
                    Pages = 432,
                    Language = "English",
                    CategoryId = 5,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Book
                {
                    Id = 11,
                    Title = "Refactoring: Improving the Design of Existing Code",
                    ISBN = "9780134757599",
                    Price = 54.99m,
                    Description = "Learn how to improve code quality through systematic refactoring techniques and best practices.",
                    StockQuantity = 18,
                    ImageUrl = "/images/books/refactoring.jpg",
                    PublishedDate = new DateTime(2018, 11, 20),
                    Pages = 448,
                    Language = "English",
                    CategoryId = 6,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Book
                {
                    Id = 12,
                    Title = "iOS Development with Swift",
                    ISBN = "9781617295071",
                    Price = 49.99m,
                    Description = "Complete guide to iOS app development using Swift, covering UI design, data management, and app store deployment.",
                    StockQuantity = 20,
                    ImageUrl = "/images/books/ios-swift.jpg",
                    PublishedDate = new DateTime(2019, 8, 15),
                    Pages = 520,
                    Language = "English",
                    CategoryId = 3,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                }
            );
        }
    }
}
