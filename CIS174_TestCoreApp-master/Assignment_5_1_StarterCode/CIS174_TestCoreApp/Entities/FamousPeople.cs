using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Entities
{
    public class FamousPeople
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        [Display(Name = "First Name")]
        public string FName { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 2)]
        [Display(Name = "Last Name")]
        public string LName { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Please enter a valid age number")]
        public int Age { get; set; }

        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        [Range(typeof(DateTime), "1/1/1900", "12/31/2018",
        ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public DateTime DOB { get; set; }


        [Required]
        [StringLength(25, MinimumLength = 4)]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required]
        [StringLength(2, MinimumLength = 2)]
        [Display(Name = "State")]
        public string State { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 5)]
        [Display(Name = "List of Accoplishments")]
        public string ListOfAccoplishments { get; set; }

    }
}
