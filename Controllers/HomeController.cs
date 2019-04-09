using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using thedashboard.Models;

namespace thedashboard.Controllers
{
    public class HomeController : Controller
    {
        private UserContext _context;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public HomeController(
            UserContext context,
            UserManager<User> userManager,
            SignInManager<User> signInManager
        )
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

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

        public async Task<IActionResult> Register(ValidateUser model)
        {
            if(ModelState.IsValid)
            {
                //Create a new User object, without adding a Password
                User NewUser = new User { FirstName = model.FirstName, LastName = model.LastName, UserName = model.Email, Email = model.Email };
                //CreateAsync will attempt to create the User in the database, simultaneously hashing the
                //password
                IdentityResult result = await _userManager.CreateAsync(NewUser, model.Password);
                //If the User was added to the database successfully
                if(result.Succeeded)
                {
                    //Sign In the newly created User
                    //We're using the SignInManager, not the UserManager!
                    await _signInManager.SignInAsync(NewUser, isPersistent: false);
                    return RedirectToAction("AdminDashboard");
                }
                //If the creation failed, add the errors to the View Model
                foreach( var error in result.Errors )
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View("Registration",model);
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
