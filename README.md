# Bookstore MVC (.NET 8)

A simple **Bookstore web application** built using **ASP.NET Core MVC 8** with **Entity Framework Core** for database access.

## 📝 Overview

This project is an MVC-based web application for managing a bookstore. Features include:

- CRUD operations for Books, Authors, Categories, and Orders
- SQL Server database integration via Entity Framework Core
- Migration-based database setup
- MVC structure with Controllers, Views, and Models

## 📂 Project Structure

```
BookstoreMVC/
├── Controllers/          # MVC controllers
├── Models/               # Entity models
├── Views/                # Razor views
├── Data/                 # EF Core DbContext and migrations
├── wwwroot/              # Static files (CSS, JS, images)
├── Program.cs            # Application entry point
├── appsettings.json      # Configuration (DB connection, etc.)
└── BookstoreMVC.csproj   # Project file
```

## ⚙️ Prerequisites

- .NET 8 SDK
- SQL Server running locally or via Docker
- Optional: Visual Studio, Visual Studio Code, or JetBrains Rider

## 💾 Setup & Run

### 1. Clone the repository

```bash
git clone https://github.com/ShroukOuda/BookStore.git
cd BookStore
```

### 2. Restore NuGet packages

```bash
dotnet restore
```

### 3. Configure database

Update your connection string in `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost,1433;Database=BookStore;User Id=sa;Password=YourPassword;TrustServerCertificate=true;MultipleActiveResultSets=true;"
  }
}
```

### 4. Apply migrations

```bash
dotnet ef database update
```

> **Note:** Make sure `dotnet-ef` tool matches your .NET SDK version:
> ```bash
> dotnet tool install --global dotnet-ef --version 8.*
> ```

### 5. Run the project

```bash
dotnet run
```

### 6. Open in browser

Navigate to `https://localhost:5001` (or the port shown in terminal).
You should see the **Bookstore home page**.

## 🛠️ Technologies Used

- **ASP.NET Core MVC 8**
- **Entity Framework Core 8**
- **SQL Server**
- **Razor Views** (HTML + Bootstrap CSS)

## 📦 Packages Included

```xml
Microsoft.AspNetCore.Identity.EntityFrameworkCore
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools
```

## 🚀 How to Test the Project

1. **Add** books, authors, and categories
2. **Create** orders and test CRUD operations
3. **Explore** different pages using MVC routing:
   - `/Books/Index` → List all books
   - `/Books/Create` → Add a new book
   - `/Authors/Index` → List authors
   - `/Categories/Index` → List categories

## 📜 Important Notes

- Ensure `dotnet-ef` tool version matches the .NET SDK version to avoid runtime errors
- For Linux users, set `DOTNET_ROOT` correctly if multiple SDKs are installed:

```bash
export DOTNET_ROOT=/usr/share/dotnet
export PATH=$DOTNET_ROOT:$PATH:$HOME/.dotnet/tools
```

## 🔗 Useful Links

- [ASP.NET Core MVC Documentation](https://docs.microsoft.com/en-us/aspnet/core/mvc/)
- [Entity Framework Core Documentation](https://docs.microsoft.com/en-us/ef/core/)

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🤝 Contributing

1. Fork the project
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request
