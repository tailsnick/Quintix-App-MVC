using Microsoft.AspNetCore.Identity;

namespace Quintix_App_MVC.Models
{
    public class RoleEdit
    {
        public IdentityRole Role { get; set; }
        public IEnumerable<UserModel> Members { get; set; }
        public IEnumerable<UserModel> NonMembers { get; set; }
    }
}
