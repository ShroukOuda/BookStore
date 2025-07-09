namespace BookStore.Services
{
    public interface IAuthorsService
    {
        IEnumerable<SelectListItem> GetSelectList();
    }
}
