using BDCDC.model;
using BDCDC.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDCDC.service
{
    class UserService:Service
    {
        private static SysUser currentUser = null;

        public SysUser findByLoginName(string loginName)
        {
            return useDbContext(ctx =>
            {
                return ctx.SysUser.Where(u => u.DLM == loginName).SingleOrDefault();
            });
        }

        public void login(string loginName, string password)
        {
            SysUser u = findByLoginName(loginName);
            if(u == null)
            {
                throw new Exception("用户不存在");
            }

            if(u.YXX != 1)
            {
                throw new Exception("用户名无效");
            }

            String pwdHash = HashUtils.md5Hash(password, u.XM + u.salt, 2);
            if (HashUtils.match(pwdHash,u.MM))
            {
                currentUser = u;
                return;
            }
            throw new Exception("用户名或密码错误");
        }
    }
}
