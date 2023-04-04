using Microsoft.AspNetCore.Mvc;
using NextwoFinalApp2023.Data;
using NextwoFinalApp2023.Models;
using NextwoFinalApp2023.Models.DataModel;
using System.Diagnostics;

namespace NextwoFinalApp2023.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FinalDbContext db;

        public HomeController(ILogger<HomeController> logger,FinalDbContext db)
        {
            this.db = db;
            _logger = logger;
        }

        public IActionResult Index()
        {
            IndexDataModel model = new IndexDataModel
            {
                courses = db.Courses.ToList(),
                blogs = db.Blogs.ToList(),
                instructors = db.Instructors.ToList(),
                partners = db.Partners.ToList(),    
            };
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}