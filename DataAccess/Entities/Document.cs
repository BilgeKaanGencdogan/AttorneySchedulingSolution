#nullable disable
using DataAccess.Records;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities
{
    public class Document : Record
    {
        [Required]
        [StringLength(100)]
        public String Name { get; set; }

        public int AppointmentId { get; set; }
        public Appointment Appointment { get; set; }

        public String DocumentPath { get; set; }

    }
}
