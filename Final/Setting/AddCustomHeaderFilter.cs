using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;

namespace Final.Setting
{
    public class AddCustomHeaderFilter:ActionFilterAttribute
    {
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            base.OnActionExecuted(actionExecutedContext);
            actionExecutedContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
            actionExecutedContext.Response.Headers.Add("Access-Control-Allow-Methods", "GET,POST,PUT,DELETE");
            actionExecutedContext.Response.Headers.Add("Access-Control-Allow-Headers", "x-requested-with,content-type");
        }
    }
}