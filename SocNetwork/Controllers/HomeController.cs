using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SocNetwork.DAL.Interface;
using SocNetwork.Domain.Entity;
using SocNetwork.Domain.ViewModels.User;
using SocNetwork.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SocNetwork.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SignInManager<User> _signInManager;
        private IUnitOfWork _unitOfWork;
        private readonly UserManager<User> _userManager;


        public HomeController(ILogger<HomeController> logger, SignInManager<User> signInManager,UserManager <User> userManagre, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _signInManager = signInManager;
            _userManager = userManagre; 
            _unitOfWork = unitOfWork;   
           
        }

        [Route("")]
        [Route("[controller]/[action]")]
        public IActionResult Index()
        {
            if (_signInManager.IsSignedIn(User))
            {
                return RedirectToAction("MyPage", "AccountManager");
            }
            else
            {
                return View(new MainViewModel());
            }
        }

        [Route("[action]")]
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
