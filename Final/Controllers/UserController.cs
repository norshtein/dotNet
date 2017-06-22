using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Final.Service;
using Final.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Final.Controllers
{
    public class UserController : ApiController
    {
        public string Get(string token)
        {
            JObject json;
            UserModel user = UserService.getUserByToken(token);
            if(user == null)
            {
                json = JObject.FromObject(new 
                    {
                        getSelfConfig = "token not found"
                    });
            }
            else
            {
                json = JObject.FromObject(new
                    {
                        username = user.UserName,
                        userid = user.UserId,
                        avatar = user.Avatar,
                        signature = user.Signature
                    });
            }

            return json.ToString();
        }
    }
}
