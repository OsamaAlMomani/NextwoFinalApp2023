using NextwoFinalApp2023.Models.shared_models;
using System.ComponentModel.DataAnnotations;

namespace NextwoFinalApp2023.Area.Administrator.Models
{
    public class Course : CommonProp
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter Title")]
        [Display(Name ="Course Title")]
        public string? CourseTitle { get; set; }
        [Required(ErrorMessage = "Enter description")]
        [Display(Name = "Course description")]
        [DataType(DataType.MultilineText)]
        public string? CourseDES { get; set; }
        [Required(ErrorMessage = "Enter Price")]
        [Display(Name = "Course Price")]
        public decimal? Price { get; set; }
        [Required(ErrorMessage = "Enter start date")]
        [Display(Name = "Course start date")]
        [DataType(DataType.Date)]
        public DateTime  StartDate { get; set; }
        [Required(ErrorMessage = "Enter Start Time")]
        [Display(Name = "Course Start Time")]
        [DataType(DataType.Time)]
        public TimeSpan StartTime   { get; set; }
        public string? Duration { get; set; }
        [Required]
        public int? Hours { get; set; }
        [Required]
        [Display(Name ="Image")]
        public string? Img { get; set; }

        public int? Rate  { get; set; }
    }
}
