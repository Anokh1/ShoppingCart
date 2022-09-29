using Shop.DataModels.CustomModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Logic.Services
{
    public interface IAdminService
    {
        ResponseModel AdminLogin(LoginModel loginModel);
        CategoryModel SaveCategory(CategoryModel newCategory);
        List<CategoryModel> GetCategories();
        bool UpdateCategory(CategoryModel categoryToUpdate);
        bool DeleteCategory(CategoryModel categoryToDelete);

    }
}
