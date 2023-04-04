using NextwoFinalApp2023.Models.shared_models;
using System.ComponentModel.DataAnnotations;

namespace NextwoFinalApp2023.Area.Administrator.Models
{
    public class Setting : CommonProp
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Enter mobile number")]
        public string? Phone { get; set; }
        public string? Phone2 { get; set; }
        public string? Mobile { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        public string? FB { get; set; }
        public string? Twitter { get; set; }
        public string? LinkedIn { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string? AboutUs { get; set; }
        public string? Fax { get; set; }
        public string? Img { get; set; }
        
    }
}
