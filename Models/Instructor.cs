using NextwoFinalApp2023.Models.shared_models;
using System.ComponentModel.DataAnnotations;

namespace NextwoFinalApp2023.Area.Administrator.Models
{
    public class Instructor : CommonProp
    {
        public int Id { get; set; }
        [Required]
        public string? InstructorName { get; set; }
        [Required]
        public string? InstructorImg { get; set; }
        [Required]
        public decimal? Position { get; set; }
        public string? FB { get; set; }
        public string? Twitter { get; set; }

        public string? LinkedIn { get; set; }
    }
}
