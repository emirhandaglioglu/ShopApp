using ShopApp.DataLayer.Abstract;
using ShopApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.BusinessLayer.Abstract
{
    public interface ICategoryService 
    {
        List<Category> GetList();
        void CategoryAdd(Category category);
        void CategoryDel(Category category);
        void CategoryUpdate(Category category);

        Category GetById(int id);
    }
}
