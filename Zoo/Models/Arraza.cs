using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zoo.Models
{
    public class Arraza
    {
        [Key]
        public int ID { get; set; }
        public string Izena { get; set; }
        public string? Deskribapena { get; set;}
        
        public int? ID_lekua { get; set; }
        [ForeignKey("ID_lekua")]
        [ValidateNever]
        public Lekua Lekua { get; set; }
        [ValidateNever]
        public string? ImageUrl { get; set; }
    }
}
