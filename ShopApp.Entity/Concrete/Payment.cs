using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Entity.Concrete
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public EnumPaymentType PaymentType { get; set; }

        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}
public enum EnumPaymentType
{
    CreditCard = 0,
    Eft = 1
}
