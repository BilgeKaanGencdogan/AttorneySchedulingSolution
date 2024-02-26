#nullable disable
using Core.Records.Bases;
using System.ComponentModel.DataAnnotations;

namespace Business.Model
{
    public class LawyerModel : Record
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int? ContactId { get; set; }

        public int LawyerTypeId { get; set; }

        public decimal Price { get; set; }

        public bool IsAvailable { get; set; }
    }
}
