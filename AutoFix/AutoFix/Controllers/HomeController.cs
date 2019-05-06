using AutoFix.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;


namespace AutoFix.Controllers
{
    public class HomeController : Controller
    {
        Repository UserDict = Repository.UsableSet;
        Repository ShopDict = Repository.UsableSet;

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
            UserDict.AddUser(U);
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
            ShopDict.AddShop(S);
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

        [HttpGet]
        public IActionResult Login()
        {

            return View(new Login());
        }

        [HttpPost]
        public IActionResult ReturnUser(Login U)
        {
            if (Repository.CheckAuth(U) ==  true)
            return RedirectToAction("Index");

            else 
            return RedirectToAction("Login");

        }
    }
}
