using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza_Restaurant.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza_Restaurant.Pages.Dashboard
{
    public class UsersListModel : PageModel
    {
        private readonly UserManager<AplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UsersListModel(UserManager<AplicationUser> userManager,RoleManager<IdentityRole> roleManager)
        {
           _userManager = userManager;
            _roleManager = roleManager;
        }

        public List<AplicationUser> Users { get; set; }
        public List<IdentityRole> Roles { get; set; }

        public void OnGet()
        {
            Users = _userManager.Users.ToList();
            Roles = _roleManager.Roles.ToList();
        }

        public async Task<IActionResult> OnGetRemoveRole(string roleName, string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            await _userManager.RemoveFromRoleAsync(user, roleName);

            return RedirectToPage();
        }

        public async Task<IActionResult> OnGetAddRole(string roleName, string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            await _userManager.AddToRoleAsync(user, roleName);

            return RedirectToPage();
        }
    }
}
 