namespace BookStore.Services
{
    public interface IAuthorsService
    {
        IEnumerable<SelectListItem> GetSelectList();
        IEnumerable<AuthorViewModel> GetAllAuthors();
        Author GetAuthorById(int id);
        void Create(AuthorFormViewModel model);
        Author? Update(AuthorFormViewModel model);
        bool Delete(int id);
    }
}
