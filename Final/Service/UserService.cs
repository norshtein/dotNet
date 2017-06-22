using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Final.Models;

namespace Final.Service
{
    public class UserService
    {
        /*
        public static UserModel getUserById(int id)
        {
            try
            {
                var ctx = Context.getInstance();
                var query = from s in ctx.user
                            where s.userId == id
                            select new UserModel
                            {
                                UserId = s.userId,
                                UserName = s.userName,
                                Avatar = s.avatar,
                                Signature = s.signature,
                                Password = s.password
                            };
                return query.First();
            }
            catch(Exception e)
            {
                return null;
            }
        }

        public static UserModel[] getAllUser()
        {
            var ctx = Context.getInstance();
            var query = from s in ctx.user
                        select new UserModel
                         {
                             UserId = s.userId,
                             UserName = s.userName,
                             Avatar = s.avatar,
                             Signature = s.signature,
                             Password = s.password
                         };
            return query.ToArray();
        }*/

        public static UserModel getUserByToken(string token)
        {
            if(Authenticate.isVaild(token))
            {
                string username = Authenticate.getUsername(token);
                var ctx = Context.getInstance();
                var query = from u in ctx.user
                            where u.userName == username
                            select new UserModel
                            {
                                UserName = u.userName,
                                UserId = u.userId,
                                Avatar = u.avatar,
                                Signature = u.signature
                            };
                return query.First();
            }
            return null;
        }

        public static bool checkVaild(string username,string password)
        {
            var ctx = Context.getInstance();
            var query = from u in ctx.user
                        where u.userName == username
                        select new UserModel
                        {
                            UserName = u.userName,
                            Password = u.password
                        };

            foreach(var item in query)
            {
                if (item.Password == password)
                    return true;
            }
            return false;
        }
    }
}