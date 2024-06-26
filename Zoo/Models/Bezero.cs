using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Zoo.Models
{
    public class Bezero:IdentityUser
    {
        [Required]
        public string? Izena {  get; set; }
        [Required]
        public string? Abizena { get; set; }
    }
}
