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
        public virtual User User { get; set; }

        public int PatmentId { get; set; }
        public virtual Payment Payment { get; set; }

        public ICollection<OrderDetail> OrderDetails{ get; set; }


    }
    public enum EnumOrderState
    {
        waiting = 0,
        unpaid = 1,
        completed = 2
    }

}
