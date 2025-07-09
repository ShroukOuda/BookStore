using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookStore.Services
{
    public interface ICategoriesService
    {
        IEnumerable<SelectListItem> GetSelectList();
    }
}
