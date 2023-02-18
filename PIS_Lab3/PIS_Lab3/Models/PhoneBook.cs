using System.ComponentModel.DataAnnotations;

namespace PIS_Lab3.Models
{
    public class PhoneBook
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        [Required(ErrorMessage = "Required епта")]
        [Phone]
        [MaxLength(13)] //custom maximum length enabled
        [MinLength(10)]//custom minimum length enabled
        [RegularExpression("^[0-9]*$", ErrorMessage = "mobile number must be numeric")]
        public string PhoneNumber { get; set; }
    }
}