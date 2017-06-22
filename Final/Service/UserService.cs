using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Final.Models;

namespace Final.Service
{
    public class UserService
    {
        public UserModel getUserById(int id)
        {
            NETEntities1 ctx = new NETEntities1();
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
    }
}