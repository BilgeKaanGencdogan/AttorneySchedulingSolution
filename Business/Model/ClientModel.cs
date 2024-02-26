#nullable disable
using Core.Records.Bases;
using System.ComponentModel.DataAnnotations;

namespace Business.Model
{
    public class ClientModel : Record
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int? ContactId { get; set; }
    }
}
