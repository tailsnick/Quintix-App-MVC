/*
 * Author Name: Rachel Hoffman
 * Date: 5/19/22
 * 
 * Summary: A player model class that allows different methods for Printing information.
*/

using System.ComponentModel.DataAnnotations;

namespace Quintrix_Web_App_Core.Models
{

    public class PlayerModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Level { get; set; }
    }
}
