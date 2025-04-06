using Microsoft.AspNetCore.Authorization;  
using Microsoft.AspNetCore.Mvc;
using Week13.Models;

namespace Week13.Controllers
{
    public class UserRolesController : Controller
    {
        public IActionResult Index()
        {
            var userRolesViewModel = new List<UserRolesViewModel>
            {
                new UserRolesViewModel
                {
                    UserName = "john_doe",
                    Roles = new List<string> { "Admin", "Manager" }
                },
                new UserRolesViewModel
                {
                    UserName = "jane_smith",
                    Roles = new List<string> { "User" }
                },
                new UserRolesViewModel
                {
                    UserName = "susan_williams",
                    Roles = new List<string> { "Manager", "User" }
                }
            };

            return View(userRolesViewModel); 
        }
        
        [Authorize(Roles = "SuperAdmin,Admin")]
        public IActionResult Manage(string userName)
        {
            var userRolesViewModel = new UserRolesViewModel
            {
                UserName = userName,
                Roles = new List<string> { "Admin", "Manager", "User" } 
            };

            return View(userRolesViewModel); 
        }
    }
}