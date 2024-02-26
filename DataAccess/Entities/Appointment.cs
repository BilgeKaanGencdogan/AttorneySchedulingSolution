#nullable disable
using Core.Records.Bases;
using DataAccess.Enums;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities
{
    public class Appointment : Record
    {
        [Required]

        public string Description { get; set; }

        public int LawyerId { get; set; }

        public Lawyer Lawyer { get; set; }

        public int ClientId { get; set; }

        public Client Client { get; set; }

        public DateTime StartDateOfAppointment { get; set; }

        public DateTime EndDateOfAppointment { get; set; }

        public Statuses Status { get; set; }
    }
}
