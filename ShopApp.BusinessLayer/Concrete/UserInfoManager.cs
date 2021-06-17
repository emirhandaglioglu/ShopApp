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
    public class UserInfoManager : IUserInfoService
    {
        EFUserInfoDAL _userinfo;
        public UserInfoManager(EFUserInfoDAL userinfo)
        {
            _userinfo = userinfo;
        }
        public bool ChangePassword(int userId, string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        public List<UserInfo> GetList()
        {
            return _userinfo.List();
        }

        public UserInfo Login(UserInfo userInfo)
        {
            var userList = _userinfo.List();
            foreach (var user in userList)
            {
                if (user.Password == userInfo.Password && user.Email == userInfo.Email)
                    return user;
            }
            return null;

        }

        public void UserInfoUpdate(UserInfo userInfo)
        {
            _userinfo.Update(userInfo);
        }
    }
}
