#nullable disable
using Core.Records.Bases;

namespace DataAccess.Entities
{
    public class Document : Record
    {


        public string Name { get; set; }

        public int AppointmentId { get; set; }
        public Appointment Appointment { get; set; }

        public string DocumentPath { get; set; }

    }
}
