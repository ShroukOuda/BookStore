using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookStore.Services
{
    public interface ICategoriesService
    {
        IEnumerable<SelectListItem> GetSelectList();
        IEnumerable<CategoryViewModel> GetAllCategories();
        Category GetCategoryDetails(int id);
        void CreateCategory(CategoryFormViewModel category);
        Category? UpdateCategory(CategoryFormViewModel category);
        bool DeleteCategory(int id);
    }
}
