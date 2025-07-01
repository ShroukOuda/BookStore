using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStore.Migrations
{
    /// <inheritdoc />
    public partial class ConfigureBookAuthorCompositeKeyAndSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BookAuthors",
                table: "BookAuthors");

            migrationBuilder.DropIndex(
                name: "IX_BookAuthors_BookId",
                table: "BookAuthors");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "BookAuthors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookAuthors",
                table: "BookAuthors",
                columns: new[] { "BookId", "AuthorId" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Biography", "BirthDate", "CreatedAt", "DeathDate", "FirstName", "LastName", "Nationality", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Software engineer and author, also known as Uncle Bob. Known for advocating software design principles and clean code practices.", new DateTime(1952, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Robert", "Martin", "American", new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Web designer and developer who has spent over a decade helping people learn about web design and programming.", new DateTime(1970, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jon", "Duckett", "British", new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "JavaScript developer and trainer, known for the You Don't Know JS book series and open source contributions.", new DateTime(1980, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kyle", "Simpson", "American", new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Software engineer and author, former Google, Microsoft, and Apple employee. Founder of CareerCup.", new DateTime(1982, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gayle", "McDowell", "American", new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Software developer and author, co-author of The Pragmatic Programmer and founding member of the Agile Alliance.", new DateTime(1964, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Andrew", "Hunt", "American", new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Software developer and author, co-author of The Pragmatic Programmer and advocate for pragmatic software development.", new DateTime(1956, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "David", "Thomas", "British", new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "Computer scientist, author, and former CTO of Disney Online, known for Head First book series.", new DateTime(1965, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Eric", "Freeman", "American", new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "Software developer and co-author of several Head First books, specializing in web development and programming education.", new DateTime(1970, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Elisabeth", "Robson", "American", new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "British software developer, author and international speaker on software development, known for refactoring and enterprise software design.", new DateTime(1963, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Martin", "Fowler", "British", new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "Multi-award winning CTO, researcher and author, known for The Phoenix Project and The DevOps Handbook.", new DateTime(1967, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gene", "Kim", "American", new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Books about programming languages, software development, and coding practices", "Programming", new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Books focused on web technologies, frameworks, and web application development", "Web Development", new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Books about developing applications for mobile devices and platforms", "Mobile Development", new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Books covering database design, administration, and data management", "Database", new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Books about deployment, infrastructure, cloud computing, and DevOps practices", "DevOps & Cloud", new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Books about software architecture, design patterns, and engineering practices", "Software Engineering", new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Description", "ISBN", "ImageUrl", "Language", "Pages", "Price", "PublishedDate", "StockQuantity", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A handbook for writing clean, readable, and maintainable code with practical examples and best practices.", "9780132350884", "/images/books/clean-code.jpg", "English", 464, 45.99m, new DateTime(2008, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, "Clean Code: A Handbook of Agile Software Craftsmanship", new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A full-color introduction to the basics of HTML and CSS for creating modern, professional websites.", "9781118008188", "/images/books/html-css.jpg", "English", 490, 35.99m, new DateTime(2011, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, "HTML and CSS: Design and Build Websites", new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 2, new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deep dive into JavaScript's scope and closures, essential concepts for mastering JavaScript.", "9781449335588", "/images/books/ydkjs-scope.jpg", "English", 98, 29.99m, new DateTime(2014, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, "You Don't Know JS: Scope & Closures", new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "189 programming questions and solutions to help you prepare for technical interviews at top tech companies.", "9780984782857", "/images/books/cracking-coding.jpg", "English", 696, 39.99m, new DateTime(2015, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, "Cracking the Coding Interview", new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 6, new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Your journey to mastery - 20th Anniversary Edition with updated content for modern development practices.", "9780135957059", "/images/books/pragmatic-programmer.jpg", "English", 352, 49.99m, new DateTime(2019, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, "The Pragmatic Programmer", new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 6, new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A brain-friendly guide to design patterns that every developer should know, with real-world examples.", "9781492078005", "/images/books/head-first-patterns.jpg", "English", 672, 54.99m, new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Head First Design Patterns", new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 2, new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unearthing the excellence in JavaScript - a guide to the language's best features and how to use them effectively.", "9780596517748", "/images/books/js-good-parts.jpg", "English", 176, 34.99m, new DateTime(2008, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, "JavaScript: The Good Parts", new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 3, new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Learn to build cross-platform mobile apps using React Native, from basic concepts to advanced techniques.", "9781617294051", "/images/books/react-native.jpg", "English", 312, 44.99m, new DateTime(2018, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "React Native in Action", new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 4, new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Master SQL fundamentals with this comprehensive guide covering queries, data manipulation, and database design.", "9781492057611", "/images/books/learning-sql.jpg", "English", 370, 39.99m, new DateTime(2020, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, "Learning SQL", new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 5, new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A novel about IT, DevOps, and helping your business win - learn DevOps principles through an engaging story.", "9781942788294", "/images/books/phoenix-project.jpg", "English", 432, 42.99m, new DateTime(2018, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, "The Phoenix Project", new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 6, new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Learn how to improve code quality through systematic refactoring techniques and best practices.", "9780134757599", "/images/books/refactoring.jpg", "English", 448, 54.99m, new DateTime(2018, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "Refactoring: Improving the Design of Existing Code", new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 3, new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Complete guide to iOS app development using Swift, covering UI design, data management, and app store deployment.", "9781617295071", "/images/books/ios-swift.jpg", "English", 520, 49.99m, new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "iOS Development with Swift", new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "BookAuthors",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 5 },
                    { 7, 6 },
                    { 8, 6 },
                    { 2, 7 },
                    { 3, 8 },
                    { 4, 9 },
                    { 10, 10 },
                    { 9, 11 },
                    { 7, 12 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BookAuthors",
                table: "BookAuthors");

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 9, 11 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 7, 12 });

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "BookAuthors",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookAuthors",
                table: "BookAuthors",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthors_BookId",
                table: "BookAuthors",
                column: "BookId");
        }
    }
}
