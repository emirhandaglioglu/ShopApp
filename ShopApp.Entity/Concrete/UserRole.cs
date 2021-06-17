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
        public UserRole()
        {
            UserInfos = new HashSet<UserInfo>();
        }
        [Key]
        public int Id { get; set; }
        public string RoleName { get; set; }


        public virtual IEnumerable<UserInfo> UserInfos { get; set; }
    }
}
