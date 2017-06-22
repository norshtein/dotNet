using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Final.Service;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Final.Controllers
{
    public class SessionController : ApiController
    {
        public string Post(string username,string password)
        {
            JObject json;
            string token = SessionService.getSession(username, password);
            if (token == null)
                json = JObject.FromObject(new
                    {
                        login = "error"
                    });
            else
                json = JObject.FromObject(new
                {
                    token = token
                });
            return json.ToString();
        }

        public string Get(string username,string password)
        {
            return Post(username, password);
        }

        public string Delete(string token)
        {
            JObject json;
            if (SessionService.deleteSession(token))
                json = JObject.FromObject(new
                    {
                        logout = "success"
                    });
            else
                json = JObject.FromObject(new
                    {
                        logout = "token not found"
                    });
            return json.ToString();
        }
    }
}
