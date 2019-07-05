using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EF_Example.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "This home page!";
        }
    }
}