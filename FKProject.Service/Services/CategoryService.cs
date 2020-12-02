using FKProject.Core.Models;
using FKProject.Core.Repositories;
using FKProject.Core.Services;
using FKProject.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKProject.Service.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork, IRepository<Category> repository) : base(unitOfWork, repository)
        {
        }
        public async Task<Category> GetWithProductsByIdAsync(int categoryId)
        {
           return await _unitOfWork.categories.GetWithProductsByIdAsync(categoryId);
        }
    }
}
