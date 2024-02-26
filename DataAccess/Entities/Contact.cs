#nullable disable
using Core.Records.Bases;
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
