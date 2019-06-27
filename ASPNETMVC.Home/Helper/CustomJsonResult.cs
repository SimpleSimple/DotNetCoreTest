using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCore.Web.Helper
{
    //public class CustomJsonResult : JsonResult
    //{
    //    //public CustomJsonResult(object value)
    //    //{

    //    //}

    //    //public CustomJsonResult(int Code, string Message, object Data)
    //    //{
    //    //    code = Code;
    //    //    message = Message;
    //    //    data = Data;
    //    //}

    //    //public int code { get; set; }
    //    //public string message { get; set; }
    //    //public object data { get; set; }

    //    public override Task ExecuteResultAsync(ActionContext context)
    //    {
    //        //if (context == null)
    //        //{
    //        //    throw new ArgumentNullException("context");
    //        //}
    //        //var response = context.HttpContext.Response;
    //        //response.ContentType = !string.IsNullOrEmpty(ContentType) ? ContentType : "application/json";
    //        //if (ContentEncoding != null)
    //        //{
    //        //    response.ContentEncoding = ContentEncoding;
    //        //}

    //        ////json转换  换个方法即可
    //        //JavaScriptSerializer serializer = new JavaScriptSerializer();
    //        //Data = new { code = code, message = message, data = data };
    //        //var json = serializer.Serialize(Data);
    //        //json = json.Replace("null", "\"\"");
    //        //response.Write(json);
    //        return new Task(null);
    //    }
    //}
}
