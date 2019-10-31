using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Entities
{
    public class Accoplishment
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

        [Required]
        [DataType(DataType.Date)]
        [Range(typeof(DateTime), "1/1/1900", "12/31/2018",
        ErrorMessage = "Value for {0} must be between {1} and {2}")]
        [Display(Name = "Date of Accomplishment")]
        public DateTime DateOfAccomplishment { get; set; }

        public ICollection<FamousPeople> FamousPeoples { get; set; }

    }
}
