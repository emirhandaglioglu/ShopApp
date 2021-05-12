using ShopApp.DataLayer.Concrate.Repositories;
using ShopApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataLayer.EntityFramework
{
    public class EFUserRoleDAL : GenericRepository<UserRole>, IUserRole
    {
    }
}
