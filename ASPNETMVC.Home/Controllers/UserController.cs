using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MvcCore.Web.Application;
using MvcCore.Web.Common;

namespace MvcCore.Web.Controllers
{
    public class UserController : WebController<IUserService>
    {
        public IActionResult Index()
        {
            var list = this.Service.GetList();
            this.ViewBag.UserList = list;
            return View();
        }
    }
}