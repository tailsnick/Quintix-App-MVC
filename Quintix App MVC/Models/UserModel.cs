using Microsoft.AspNetCore.Identity;

namespace Quintix_App_MVC.Models
{
    public class UserModel : IdentityUser
    {
        public string Bagels { get; set; } = "";
    }
}
