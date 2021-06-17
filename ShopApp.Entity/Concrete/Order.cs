using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Entity.Concrete
{
    public class Order
    {
        [Key]
        public int Id{ get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate{ get; set; }
        public double TotalPrice { get; set; }
        public EnumOrderState OrderState { get; set; }


        public int UserId { get; set; }
        public virtual UserInfo UserInfo { get; set; }


        public ICollection<OrderDetail> OrderDetails { get; set; }

    }
    public enum EnumOrderState
    {
        Beklemede = 0,
        Hazırlanıyor = 1,
        Tamamlandı = 2
    }

}
