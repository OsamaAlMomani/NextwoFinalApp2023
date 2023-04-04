using NextwoFinalApp2023.Models.shared_models;
using System.ComponentModel.DataAnnotations;

namespace NextwoFinalApp2023.Area.Administrator.Models
{
    public class Blog :CommonProp
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string? Description { get; set; }
        [Required]
        public string? Img { get; set; }
    }
}
