using Microsoft.AspNetCore.Mvc;

namespace Week13.Controllers;

public class RoleManagerController: Controller
{
    public IActionResult Index()
    {
        
        var roles = GetAvailableRoles(); 

        return View(roles);
    }
    
    public IActionResult AddRole()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult AddRole(string roleName)
    {
        if (!string.IsNullOrEmpty(roleName))
        {
            AddNewRole(roleName);
            return RedirectToAction("Index");
        }
        
        ViewBag.ErrorMessage = "Role name cannot be empty.";
        return View();
    }
    
    private List<string> GetAvailableRoles()
    {
        return new List<string> { "Admin", "User", "Manager" };  
    }

    private void AddNewRole(string roleName)
    {
        
    }
}