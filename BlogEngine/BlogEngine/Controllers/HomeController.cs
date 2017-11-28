using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogEngine.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogEngine.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var allPosts = DataRepository.GetAllPosts().OfType<PostPreviewModel>().ToArray();
            return View(allPosts);
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
