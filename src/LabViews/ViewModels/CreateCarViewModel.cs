using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LabViews.ViewModels
{
    public class CreateCarViewModel
    {
        [Display(Name = "Make")]
        [Required(ErrorMessage = "Enter a Car Brand")]
        public string Brand { get; set; }

        [Display(Name = "Doors")]    
        [Range(3, 5, ErrorMessage = "Number between 3 - 5")]
        public int Doors { get; set; }

        [Display(Name = "TopSpeed")]
        [Range(0, 300, ErrorMessage = "Max value of 300")]
        public int TopSpeed { get; set; }

        [Display(Name = "I Accept terms and conditions")]
        [Required(ErrorMessage = "Required")]
        public bool AcceptTerms { get; set; }
    }
}
