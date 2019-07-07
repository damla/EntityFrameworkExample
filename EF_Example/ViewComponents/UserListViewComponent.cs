using EF_Example.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Example.ViewComponents
{
    public class UserListViewComponent: ViewComponent
    {
        private ECommerceContext _context;

        public UserListViewComponent(ECommerceContext context)
        {
            _context = context; // dependency injection
        }

        public IViewComponentResult Invoke(string filter)
        {
            filter = HttpContext.Request.Query["filter"]; // this will read the query string which is wrote in url side
            // return View(_context.Users); // it will return all users but this is not ok for best practices.
            return View(new UserListViewModel
            {
                Users = _context.Users.Where(u => u.FirstName.ToLower().Contains(filter)).ToList()
            });
        }
    }
}
