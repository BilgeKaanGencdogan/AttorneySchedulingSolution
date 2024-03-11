#nullable disable
using Core.Records.Bases;
using DataAccess.Enums;

namespace DataAccess.Entities
{
    public class Appointment : Record
    {


        public string Description { get; set; }

        public int LawyerId { get; set; }

        public Lawyer Lawyer { get; set; }

        public int ClientId { get; set; }

        public Client Client { get; set; }

        public DateTime StartDateOfAppointment { get; set; }

        public DateTime? EndDateOfAppointment { get; set; }

        public Statuses Status { get; set; }

        public List<Document> Documents { get; set; }
    }
}
