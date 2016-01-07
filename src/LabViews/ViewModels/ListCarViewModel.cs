using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LabViews.ViewModels
{
    public class ListCarViewModel
    {
        [Display(Name = "Car Brand")]
        public string Brand { get; set; }

        public bool ShowAsFast { get; set; }
    }
}
