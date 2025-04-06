using Microsoft.AspNetCore.Mvc;

namespace Week13.Components
{
    public class UserRoleViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            bool isAdminOrSuperAdmin = User.IsInRole("SuperAdmin") || User.IsInRole("Admin");
            
            return View(isAdminOrSuperAdmin);
        }
    }
}