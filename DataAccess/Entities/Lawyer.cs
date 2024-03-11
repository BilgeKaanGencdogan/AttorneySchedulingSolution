#nullable disable
using Core.Records.Bases;

namespace DataAccess.Entities
{
    public class Lawyer : Record
    {

        public string Name { get; set; }

        public int LawyerTypeId { get; set; }

        public LawyerType LawyerType { get; set; }

        public decimal Price { get; set; }

        public bool IsAvailable { get; set; }
        public string TelephoneNumber { get; set; }
        public string Address { get; set; }

        public List<Appointment> Appointments { get; set; }
        
    }
}
