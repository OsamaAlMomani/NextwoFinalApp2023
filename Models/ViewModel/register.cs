using System.ComponentModel.DataAnnotations;

namespace NextwoFinalApp2023.Models.ViewModel
{
    public class register
    {
        public int Id { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Not Match!!")]
        public string? ConfirmPassword { get; set; }
    }
}
