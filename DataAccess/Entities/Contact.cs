#nullable disable
using DataAccess.Records;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities
{
    public class Contact : Record
    {
        [Required]
        public string TelephoneNumber { get; set; }

        [Required]
        public string Address { get; set; }


    }
}
