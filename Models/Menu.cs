using NextwoFinalApp2023.Models.shared_models;
using System.ComponentModel.DataAnnotations;

namespace NextwoFinalApp2023.Models
{
    public class Menu : CommonProp
    {
        [Display(Name = "Menu Id")]
        public int MenuId { get; set; }
        [Display(Name = "Title")]
        [Required(ErrorMessage = "Enter Title")]
        [MaxLength(13, ErrorMessage = "Max 13 char")]
        [MinLength(3, ErrorMessage = "Min 3 char")]
        public string? MenuTitle { get; set; }
        [Display(Name = "Menu Url")]
        [Required(ErrorMessage = "Enter Menu URL")]
        public string? MenuUrl { get; set; }
        [Display(Name = "Perant")]
        public int? ParentId { get; set; }
    }
}
