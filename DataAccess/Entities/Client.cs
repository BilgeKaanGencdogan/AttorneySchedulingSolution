#nullable disable
using Core.Records.Bases;

namespace DataAccess.Entities
{
    public class Client : Record
    {

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int? ContactId { get; set; }

        public Contact Contact { get; set; }
    }
}
