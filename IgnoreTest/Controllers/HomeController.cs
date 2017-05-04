using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Options;
using Npgsql;
using StudioCodeTest.Infrastructure.Options;
using StudioCodeTest.Models;

namespace StudioCodeTest.Controllers
{

    public class HomeController : BaseController
    {
        public HomeController(IOptions<DatabaseOption> databaseOption):base(databaseOption)
        {
        }

        public IActionResult Index()
        {
            return View(IndexViewModel.Load(this.Connection));
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
