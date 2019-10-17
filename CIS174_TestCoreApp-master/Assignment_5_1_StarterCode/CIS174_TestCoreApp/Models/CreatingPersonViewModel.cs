using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Models
{
    //I named this ViewModel as such because I didn't want to make my older CreatePersonViewModel assignment not work or just be different? If that makes sense.
    public class CreatingPersonViewModel
    {
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
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [Display(Name = "ConfirmPassword")]
        public string ConfirmPassword { get; set; }

        public string Country { get; set; }

        public IEnumerable<SelectListItem> Countries { get; set; } = new List<SelectListItem>
                    {
                       new SelectListItem{Value = "USA", Text = "USA" },
                       new SelectListItem{Value = "Mexico", Text = "Mexico"},
                       new SelectListItem {Value = "Canada", Text = "Canada"},
                       new SelectListItem {Value = "Indonesia", Text = "Indonesia"},
                       new SelectListItem {Value = "Ireland", Text = "Ireland"},
                    };
    }
}
