using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HomeworkBlazorServer.Models
{
    public class PersonModel
    {
        [Required]
        [DisplayName("First Name")]
        public string? FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        public string? LastName { get; set; }

        [Required]
        [DisplayName("Is Active")]
        public bool IsActive { get; set; }
    }
}
