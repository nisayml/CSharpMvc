using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CSharpMvc.Models;

namespace CSharpMvc.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View(new ErrorViewModel(){RequestId="12"});
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}