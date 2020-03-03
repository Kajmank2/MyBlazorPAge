using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApplication.Data
{
    public class Customer
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(15,ErrorMessage ="Name is too long")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Second name is required")]
        [StringLength(15, ErrorMessage = "Second name is too long")]
        public string SecondName { get; set; }
        [Required(ErrorMessage = "Birthday date is required")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Birthday { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        public Customer(int id, string name,string secondName, DateTime birthday,
            string email)
        {
            this.Id = id;
            this.Name = name;
            this.SecondName = secondName;
            this.Birthday = birthday;
            this.Email = email;
        }
        public Customer()
        {

        }
    }
}
