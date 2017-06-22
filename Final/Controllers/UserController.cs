using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Final.Service;
using Final.Models;

namespace Final.Controllers
{
    public class UserController : ApiController
    {
        public UserModel[] Get(int id)
        {
        }

        public UserModel[] Get()
        {
            NETEntities1 ctx = new NETEntities1();
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
        }
    }
}
