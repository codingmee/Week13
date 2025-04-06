namespace Week13.Models
{
    public class UserRoleManageViewModel
    {
        public string UserName { get; set; }
        public List<string> AvailableRoles { get; set; }
        public List<string> SelectedRoles { get; set; }
        
        public UserRoleManageViewModel()
        {
            AvailableRoles = new List<string>(); 
            SelectedRoles = new List<string>();  
            UserName = string.Empty; 
        }
    }
}