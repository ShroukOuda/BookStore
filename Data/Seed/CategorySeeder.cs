namespace BookStore.Data.Seed
{
    public class CategorySeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Category>().HasData(
                 new Category
                 {
                     Id = 1,
                     Name = "Programming",
                     Description = "Books about programming languages, software development, and coding practices",
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow
                 },
                new Category
                {
                    Id = 2,
                    Name = "Web Development",
                    Description = "Books focused on web technologies, frameworks, and web application development",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Category
                {
                    Id = 3,
                    Name = "Mobile Development",
                    Description = "Books about developing applications for mobile devices and platforms",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Category
                {
                    Id = 4,
                    Name = "Database",
                    Description = "Books covering database design, administration, and data management",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Category
                {
                    Id = 5,
                    Name = "DevOps & Cloud",
                    Description = "Books about deployment, infrastructure, cloud computing, and DevOps practices",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Category
                {
                    Id = 6,
                    Name = "Software Engineering",
                    Description = "Books about software architecture, design patterns, and engineering practices",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                }
            );
        }
    }
}
