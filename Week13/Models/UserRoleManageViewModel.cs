namespace Week13.Models
{
    public class UserRolesViewModel
    {
        public string UserName { get; set; } = string.Empty;  
        public List<string> Roles { get; set; } = new List<string>();  
    }
}