using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ASPNETMVC.Home.Attributes
{
    public class LoginValidAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);

            //MyHttpContext.Current.Response.ContentType = "text/html";
            //using (StreamWriter writer = new StreamWriter(MyHttpContext.Current.Response.Body))
            //{
            //    writer.Write("-----This is OnActionExecuted-----");
            //}
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            //MyHttpContext.Current.Response.ContentType = "text/html";
            //using (StreamWriter writer = new StreamWriter(MyHttpContext.Current.Response.Body))
            //{
            //    writer.Write("-----This is OnActionExecuting-----");
            //}
        }
    }
}
