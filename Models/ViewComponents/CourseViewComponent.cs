using Microsoft.AspNetCore.Mvc;
using NextwoFinalApp2023.Data;

namespace NextwoFinalApp2023.Models.ViewComponents
{
    public class CourseViewComponent:ViewComponent
    {
        private readonly FinalDbContext db;
        public CourseViewComponent( FinalDbContext db)
        {
            this.db=db;
        }
        public IViewComponentResult Invoke()
        {
            var data = db.Courses.OrderByDescending(x => x.StartDate).Take(6);
            return View(data);
        }
    }
}
