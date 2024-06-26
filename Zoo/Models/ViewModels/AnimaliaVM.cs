using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Zoo.Models.ViewModels
{
    public class AnimaliaVM
    {
        public Animalia Animalia { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> ArrazaList { get; set; }
    }
}
