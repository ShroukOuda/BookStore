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
    }
}
