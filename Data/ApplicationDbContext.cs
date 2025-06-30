namespace BookStore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            

        }

        DbSet<Book> Books { get; set; }
        DbSet<Author> Authors { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<BookAuthor> BookAuthors { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
