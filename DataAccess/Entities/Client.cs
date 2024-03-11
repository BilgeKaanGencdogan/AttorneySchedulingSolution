#nullable disable
using Core.Records.Bases;

namespace DataAccess.Entities
{
    public class Client : Record
    {

        public string Name { get; set; }

        public string TelephoneNumber { get; set; }
        public string Address { get; set; }


        public DateTime DateOfBirth { get; set; }

       

        public List<Appointment> Appointments { get; set; }
    }
}
