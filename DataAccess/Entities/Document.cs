﻿#nullable disable
using DataAccess.Records;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities
{
    public class Document : Record
    {
        [Required]

        public string Name { get; set; }

        public int AppointmentId { get; set; }
        public Appointment Appointment { get; set; }

        public string DocumentPath { get; set; }

    }
}
