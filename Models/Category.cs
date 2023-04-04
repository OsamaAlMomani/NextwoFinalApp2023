using NextwoFinalApp2023.Models.shared_models;
using System.ComponentModel.DataAnnotations;

namespace NextwoFinalApp2023.Area.Administrator.Models
{
    public class Category : CommonProp
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
    }
}
