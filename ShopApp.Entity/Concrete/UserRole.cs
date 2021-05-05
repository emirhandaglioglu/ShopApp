using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Entity.Concrete
{
    public class UserRole
    {
        [Key]
        public int Id { get; set; }
        public string UserRoleName { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
