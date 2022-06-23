using Microsoft.AspNetCore.Mvc;
using myResumes.Models;
using System.Diagnostics;

namespace myResumes.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            ViewBag.Title = "My resumes";
            return View();
        }

        public ViewResult aboutMePage()
        {
            return View();
        }

    }
}