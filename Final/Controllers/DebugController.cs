using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FirstCOMLib;

namespace Final.Controllers
{
    public class DebugController : ApiController
    {
        public int Get(int a,int b)
        {
            FirstCOMLib.FirstClass f1 = new FirstClass();
            return f1.Add(a, b);
        }
    }
}
