using System.ComponentModel.DataAnnotations;

namespace Quintix_App_MVC.Models
{
    public class RoleModification
    {
        [Required]
        public string RoleName { get; set; } = "";

        public string RoleId { get; set; } = "";

        public string[] AddIds { get; set; } = new string[0];

        public string[] DeleteIds { get; set; } = new string[0];
    }
}
