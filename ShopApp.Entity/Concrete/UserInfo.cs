using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Entity.Concrete
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public int UserRoleId { get; set; }
        public UserRole UserRole { get; set; }

        public string GetName()
        {
            return this.FirstName + " " + this.LastName;
        }

    }
}
