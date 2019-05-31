using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    public class ControllerBase2 : ControllerBase
    {
        public virtual string ResponseMessage(object data)
        {
            //JavaScriptSerialize jss = new JavaScriptSerialize();
            return "";
        }

        public virtual string FormatDate(DateTime datetime)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.Converters.Insert(0, new IsoDateTimeConverter());
            return JsonConvert.SerializeObject(settings);
        }
    }
}
