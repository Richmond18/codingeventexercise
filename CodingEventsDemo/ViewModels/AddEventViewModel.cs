using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodingEventsDemo.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage ="please enter Name")]
        [StringLength(50, MinimumLength =3, ErrorMessage = "Must between 3 to 50 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "please enter description")]
        [StringLength(500)]
        public string Description { get; set; }

        [EmailAddress]
        public string ContactEmail { get; set; }
    }
}
