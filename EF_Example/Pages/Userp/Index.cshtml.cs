using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_Example.Entities;
using EF_Example.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EF_Example.Pages.Userp
{
    public class IndexModel : PageModel
    {
        private readonly ECommerceContext _context;
        public IndexModel(ECommerceContext context)
        {
            _context = context;
        }
        public List<User> Users { get; set; }
        public void OnGet(string search)
        {
            Users = string.IsNullOrEmpty(search)
                ?_context.Users.ToList()
                :_context.Users.Where(s => s.FirstName.ToLower().Contains(search)).ToList();
        }
        [BindProperty]
        public new User User { get; set; }
        public IActionResult OnPost()
        {
            _context.Users.Add(User);
            _context.SaveChanges();
            return RedirectToPage("/Userp/Index");
        }
    }
}