using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPNETMVC_Core.Models;
using System.IO;

namespace ASPNETMVC_Core.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return View();

            Response.ContentType = "text/html";

            using (StreamWriter sw = new StreamWriter(Response.Body))
            {
                sw.Write("Write a string to response in Index!");
            }

            return new EmptyResult();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
