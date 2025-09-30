using Microsoft.EntityFrameworkCore;

namespace BookStore.Services
{
    public class AuthorsService : IAuthorsService
    {
        private readonly ApplicationDbContext _context;

        public AuthorsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<SelectListItem> GetSelectList()
        {
            return _context.Authors
                .OrderBy(a => a.FirstName)
                .ThenBy(a => a.LastName)
                .Select(a => new SelectListItem
                {
                    Value = a.Id.ToString(),
                    Text = a.FullName
                })
                .ToList();
        }

        public IEnumerable<AuthorViewModel> GetAllAuthors()
        {
            return _context.Authors
                .Select(a => new AuthorViewModel
                {
                    Id = a.Id,
                    Name = a.FullName,
                    Biography = a.Biography,
                    CreatedAt = a.CreatedAt,
                    UpdatedAt = a.UpdatedAt,
                    BookCount = a.BookAuthors.Count()
                    
                })
                .ToList();
        }

        public Author GetAuthorById(int id)
        {
            return _context.Authors.Find(id);
        }

        public void Create(AuthorFormViewModel model)
        {
            Author author = new()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Biography = model.Biography,
                BirthDate = model.BirthDate,
                DeathDate = model.DeathDate,
                Nationality = model.Nationality,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            _context.Add(author);
            _context.SaveChanges();
        }

        public Author? Update(AuthorFormViewModel model)
        {
            var author = _context.Authors.Find(model.Id);

            if (author is null)
                return null;
            author.FirstName = model.FirstName;
            author.LastName = model.LastName;
            author.Biography = model.Biography;
            author.BirthDate = model.BirthDate;
            author.DeathDate = model.DeathDate;
            author.Nationality = model.Nationality;
            author.UpdatedAt = DateTime.Now;

            _context.SaveChanges();
            return author;
        }

        public bool Delete(int id)
        {
            bool isDeleted = false;

            var author = _context.Authors
                .Include(a => a.BookAuthors)
                .ThenInclude(ba => ba.Book)
                .FirstOrDefault(a => a.Id == id);

            if (author is null)
                return isDeleted;
            
            _context.Remove(author);
            _context.SaveChanges();
            
            return isDeleted;
        }
    }
}
