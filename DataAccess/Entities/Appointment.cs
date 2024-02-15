#nullable disable
using DataAccess.Enums;
using DataAccess.Records;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities
{
    public class Appointment : Record
    {
        [Required]
        [StringLength(200)]
        public String Name { get; set; }

        public int LawyerId { get; set; }

        public Lawyer Lawyer { get; set; }

        public int ClientId { get; set; }

        public Client Client { get; set; }

        public DateTime DateOfAppointment { get; set; }

        public String AddressOfAppointment { get; set; }

        public Statuses Status { get; set; }
    }
}
