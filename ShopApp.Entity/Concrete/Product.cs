using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Entity.Concrete
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double? Price { get; set; }
        public int StockAmount { get; set; }
        public string ProductPicture{ get; set; }

        public int CategoryId { get; set; }
        public virtual  Category Category{ get; set; }

       



    }
}
