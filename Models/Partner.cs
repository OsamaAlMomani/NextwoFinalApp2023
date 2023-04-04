using NextwoFinalApp2023.Models.shared_models;
using System.ComponentModel.DataAnnotations;

namespace NextwoFinalApp2023.Area.Administrator.Models
{
    public class Partner : CommonProp
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Img { get; set; }
    }
}
