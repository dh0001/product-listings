using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using store2.Data;
using store2.Models;
using Microsoft.AspNetCore.Identity;
using store2.Models.AdminViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace store2.Controllers
{
    public class AdminController : Controller
    {

        private readonly RoleManager<ApplicationRole> roleManager;

        public AdminController(RoleManager<ApplicationRole> roleManager)
        {
            this.roleManager = roleManager;
        }
        public IActionResult Index()
        {
            List<RoleListViewModel> model = new List<RoleListViewModel>();
            model = roleManager.Roles.Select(r => new RoleListViewModel
            {
                RoleName = r.Name,
                Id = r.Id,
                Description = r.Description,
                //NumberOfUsers = r.Users.Count
            }).ToList();
            return View(model);
        }
    }
}
