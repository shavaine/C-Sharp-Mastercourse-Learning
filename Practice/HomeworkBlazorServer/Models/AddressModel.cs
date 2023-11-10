using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HomeworkBlazorServer.Models
{
    public class AddressModel
    {
        [Required]
        public string? Address { get; set; }

        [Required]
        public string? City { get; set; }

        [Required]
        public string? State { get; set; }

        [Required]
        [DisplayName("Postal Code")]
        public string PostalCode { get; set; }
    }
}
