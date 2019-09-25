using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CrudWithBlazorApp.Models
{
    public class Person
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Please provide a valid name")]
        [StringLength(150,MinimumLength = 2,ErrorMessage = "Name should be minimun two character")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please provide a valid last name")]
        [StringLength(150, MinimumLength = 2, ErrorMessage = "last name should be minimun two character")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please provide a date of birth")]
        public DateTime DateofBirth { get; set; }

        [DataType(DataType.MultilineText)]
        [StringLength(500,ErrorMessage = "Maximun length is 500")]
        public string Address { get; set; }

        [DataType(DataType.PhoneNumber)]
        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [Required(ErrorMessage = "Please provide a valid email address")]
        [StringLength(60)]
        public string Email { get; set; }

        [StringLength(60, ErrorMessage = "Maximun length is 60")]
        [DataType(DataType.Text)]
        public string Ocupation { get; set; }

       [Range(18,99,ErrorMessage = "age sould be between 18 and 99")]
        public int Age { get { return DateofBirth.Date.Year - DateTime.UtcNow.Year; } private set { } }
    }
}
