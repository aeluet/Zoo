using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

namespace Zoo.Models
{
    public class Animalia
    {

        [Key]
        public int ID { get; set; }
        public string Izena { get; set; }
        public DateOnly Sarrera_data {  get; set; }
        public DateOnly urte_betetzea {  get; set; } 

        public int? ID_arraza { get; set; }
        [ForeignKey("ID_arraza")]
        [ValidateNever]
        public Arraza Arraza { get; set; }
        [ValidateNever]
        public string? ImageUrl { get; set; }
    }
}
