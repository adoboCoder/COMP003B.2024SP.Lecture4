// TODO: add data annotations
using System.ComponentModel.DataAnnotations;

namespace COMP003B._2024SP.Lecture4.ViewModels
{
    public class ContactViewModel
    {
        // TODO: add the appropriate properties and data annotations
        [Required, StringLength(100), Display(Name = "Full Name")]
        public string Name { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, Phone]
        public string Phone { get; set; }
        [Required, Range(0, 120)]
        public int Age { get; set; }
    }
}
