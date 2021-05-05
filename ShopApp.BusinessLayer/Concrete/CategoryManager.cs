using ShopApp.BusinessLayer.Abstract;
using ShopApp.DataLayer.Abstract;
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
        ICategory _category;

        public CategoryManager(ICategory category)
        {
            _category = category;
        }

        public List<Category> GetList()
        {
            throw new NotImplementedException();
        }  
    }
}
