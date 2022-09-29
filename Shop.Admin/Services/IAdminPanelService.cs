using Shop.DataModels.CustomModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Admin.Services
{
    interface IAdminPanelService
    {
        Task<ResponseModel> AdminLogin(LoginModel loginModel);
        Task<CategoryModel> SaveCategory(CategoryModel newCategory);
        Task<List<CategoryModel>> GetCategories();
        Task<bool> UpdateCategory(CategoryModel categoryToUpdate);
        Task<bool> DeleteCategory(CategoryModel categoryToDelete);
        
    }
}
