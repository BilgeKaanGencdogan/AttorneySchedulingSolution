#nullable disable
using DataAccess.Records;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities
{
    public class Lawyer : Record
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int? ContactId { get; set; }

        public Contact Contact { get; set; }

        public int LawyerTypeId { get; set; }

        public LawyerType LawyerType { get; set; }

        public decimal Price { get; set; }

        public bool IsAvailable { get; set; }
    }
}
