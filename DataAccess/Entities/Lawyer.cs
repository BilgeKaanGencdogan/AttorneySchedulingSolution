#nullable disable
using DataAccess.Records;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities
{
    public class Lawyer : Record
    {
        [Required]
        [StringLength(100)]
        public String Name { get; set; }

        [Required]
        [StringLength(50)]
        public String ContactNo { get; set; }

        [Required]
        [StringLength(100)]
        public String TypeOfLawyer { get; set; }
    }
}
