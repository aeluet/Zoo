using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Zoo.Models
{
    public class Langile: IdentityUser
    {
        [Required]
        public string? Izena { get; set; }
        [Required]
        public string? Abizena { get; set; }
        public string? Postua { get; set; }
        public string? Turnoa { get; set; }
    }
}
