using System.ComponentModel.DataAnnotations;

namespace HomeworkBlazerWasm.Models
{
    public class AddressModel
    {
        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Region { get; set; }

        [Required]
        public string PostalCode { get; set; }
    }
}
