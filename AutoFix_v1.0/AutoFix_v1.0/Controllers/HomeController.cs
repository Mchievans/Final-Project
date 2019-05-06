using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoFix_v1._0.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AutoFix_v1._0.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddUser()
        {
            return View(new User());
        }

        [HttpPost]
        public IActionResult AddUser(User U)
        {
            //UserDict.AddUser(U);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddShop()
        {

            return View(new Shop());
        }

        [HttpPost]
        public IActionResult AddShop(Shop S)
        {
            //ShopDict.AddShop(S);
            return RedirectToAction("Index");
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
