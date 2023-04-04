using Microsoft.AspNetCore.Cors;
using System.ComponentModel.DataAnnotations;

namespace NextwoFinalApp2023.Models.shared_models
{
    public class CommonProp
    {
        [Display(Name ="Creation Date")]
        public DateTime? date { get; set; }
        [Display(Name = "Is Published")]
        public bool IsPublished { get; set; }
        //Soft Delete
        [Display(Name = "Is Deleted")]
        public bool IsDeleted { get; set; }
        [Display(Name ="User")]
        public string? UserId { get; set; }

    }
}
