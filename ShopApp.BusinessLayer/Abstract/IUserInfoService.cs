using ShopApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.BusinessLayer.Abstract
{
    public interface IUserInfoService
    {
        List<UserInfo> GetList();
        UserInfo Login(UserInfo userInfo);
        bool ChangePassword(int userId, string oldPassword, string newPassword);
        void UserInfoUpdate(UserInfo userInfo);
    }
}
