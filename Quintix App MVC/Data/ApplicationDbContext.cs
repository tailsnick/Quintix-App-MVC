using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Quintix_App_MVC.Models;
using Quintrix_Web_App_Core.Models;

namespace Quintix_App_MVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<PlayerModel> PlayerModelDatas { get; set; }
        public DbSet<UserModel> Users { get; set; }
    }
}