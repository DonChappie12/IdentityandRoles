using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using thedashboard.Models;

namespace thedashboard.Controllers
{
    public class HomeController : Controller
    {

        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("login")]
        public IActionResult Login()
        {
            // await _signInManager.SignOutAsync();
            return View();
        }

        [Route("/register")]
        public IActionResult Registration()
        {
            return View();
        }

        [Route("/dashboard")]
        public IActionResult Dashboard()
        {
            return View();
        }

        [Route("/dashboard/admin")]
        public IActionResult AdminDashboard()
        {
            return View();
        }

        [Route("user/edit")]
        public IActionResult Edit()
        {
            return View();
        }

        [Route("user/new")]
        public IActionResult NewUser()
        {
            return View();
        }

        [Route("user/edit/id")]
        public IActionResult AdminEditUser()
        {
            return View();
        }

        [Route("user/show/id")]
        public IActionResult UserInfo()
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
