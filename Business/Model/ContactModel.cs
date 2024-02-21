#nullable disable
using DataAccess.Records;
using System.ComponentModel.DataAnnotations;

namespace Business.Model
{
    public class ContactModel : Record
    {
        [Required]
        public string TelephoneNumber { get; set; }

        [Required]
        public string Address { get; set; }
    }
}
