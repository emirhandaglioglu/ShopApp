using ShopApp.BusinessLayer.Abstract;
using ShopApp.DataLayer.Abstract;
using ShopApp.DataLayer.Concrate.Repositories;
using ShopApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDAL _category;
        public CategoryManager(ICategoryDAL category)
        {
            _category = category;
        }

        public void CategoryAdd(Category category)

        {
            _category.Insert(category);
        }

        public void CategoryDel(Category category)
        {
            _category.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _category.Update(category);
        }

        public Category GetById(int id)
        {
            return _category.Get(x => x.Id == id);
        }

        public List<Category> GetList()
        {
            return _category.List();
        }

        
    }
}
