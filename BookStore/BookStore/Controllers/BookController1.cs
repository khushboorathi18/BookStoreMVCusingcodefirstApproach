using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class BookController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult InsertBook()
        {
            return View();
        }
    }
}
