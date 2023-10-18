using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategory _category;

        public CategoryManager(ICategory category)
        {
            _category = category;
        }

        public void CategoryAdd(Category category)
        {
            _category.Add(category);
        }

        public void CategoryRemove(Category category)
        {
            _category.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _category.Update(category);
        }

        public Category GetById(int id)
        {
            return _category.GetById(id);
        }

        public List<Category> ListAll()
        {
            return _category.ListAll();
        }
    }
}
