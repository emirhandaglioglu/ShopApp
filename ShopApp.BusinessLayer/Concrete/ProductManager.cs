using ShopApp.BusinessLayer.Abstract;
using ShopApp.DataLayer.EntityFramework;
using ShopApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        EFProductDAL _product;

        public ProductManager(EFProductDAL product)
        {
            _product = product;
        }

        public void ProductAdd(Product product)
        {
            _product.Insert(product);
        }

        public void ProductDel(Product product)
        {
            _product.Delete(product);
        }

        public void ProductUpdate(Product product)
        {
            _product.Update(product);
        }

        public Product GetById(int id)
        {
            return _product.Get(x => x.Id == id);
        }

        public int getContainsProduct(string letter)
        {
            int sayac = 0;
            var productList = _product.List();
            foreach (var product in productList)
            {
                if (product.ProductName.ToLower().Contains(letter))
                {
                    sayac++;
                }
            }
            return sayac;
        }

        public List<Product> GetList()
        {
            return _product.List();
        }

        public void getMaxProductCount()
        {
            var productList = _product.List();

            var result = productList.GroupBy(x=>x.CategoryId).FirstOrDefault();
            var test1 = result.Count();

        }

       
    }
}
