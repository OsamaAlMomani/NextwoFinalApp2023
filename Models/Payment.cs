
using NextwoFinalApp2023.Models.shared_models;
using System.ComponentModel.DataAnnotations;

namespace NextwoFinalApp2023.Area.Administrator.Models
{
    public class Payment : CommonProp
    {
        [Required]
        public Guid PaymentId { get; set; }
        public string? InVoiceId { get; set; }
        public decimal? Total { get; set; }
        public bool? IsSuccess { get; set; }
    }
}
