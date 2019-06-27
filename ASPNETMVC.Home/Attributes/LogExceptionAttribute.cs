using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCore.Web.Attributes
{
    public class LogExceptionAttribute : ActionFilterAttribute
    {
        

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            //context.HttpContext.Response.Write();
            base.OnActionExecuted(context);
        }


    }
}
