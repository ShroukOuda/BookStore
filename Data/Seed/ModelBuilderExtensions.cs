namespace BookStore.Data.Seed
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            AuthorSeeder.Seed(modelBuilder);
            BookSeeder.Seed(modelBuilder);
            CategorySeeder.Seed(modelBuilder);
            BookAuthorSeeder.Seed(modelBuilder);
        }
    }
    
}
