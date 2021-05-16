using ShopApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.BusinessLayer.Abstract
{
    public interface IProductService
    {
        List<Product> GetList();
        void ProductAdd(Product product);
        void ProductDel(Product product);
        void ProductUpdate(Product product);

        Product GetById(int id);
        int getContainsProduct(string letter);
    }
}
