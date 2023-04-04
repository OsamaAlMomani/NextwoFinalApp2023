using NextwoFinalApp2023.Area.Administrator.Models;

namespace NextwoFinalApp2023.Models.DataModel
{
    public class IndexDataModel
    {
        public IList<Course>? courses { get; set; } 
        public IList<Blog>? blogs { get; set; } 
        public IList<Partner>? partners { get; set; } 
        public IList<Instructor>? instructors { get; set; } 
    }
}
