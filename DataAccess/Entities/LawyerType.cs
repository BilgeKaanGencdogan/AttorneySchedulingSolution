﻿#nullable disable
using Core.Records.Bases;

namespace DataAccess.Entities
{
    public class LawyerType : Record
    {
        public string Name { get; set; }
        public List<Lawyer> Lawyers { get; set; }
    }
}
