#nullable disable
using Core.Records.Bases;

namespace DataAccess.Entities
{
    public class Lawyer : Record
    {

        public string Name { get; set; }

        public int? ContactId { get; set; }

        public Contact Contact { get; set; }

        public int LawyerTypeId { get; set; }

        public LawyerType LawyerType { get; set; }

        public decimal Price { get; set; }

        public bool IsAvailable { get; set; }
    }
}
