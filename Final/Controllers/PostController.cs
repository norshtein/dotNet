using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Final.Service;

namespace Final.Controllers
{
    public class PostController : ApiController
    {
        public string Get(int postid,string token)
        {
            if (!Authenticate.isVaild(token))
                return (new string[] { "getpost", "error" }).ToString();
            return PostService.getAllPost(Authenticate.getUsername(token));
        }

        public String Get(string token)
        {
            if (!Authenticate.isVaild(token))
                return (new string[] { "getpost", "error" }).ToString();
            return PostService.getAllPost(Authenticate.getUsername(token));
        }
    }
}
