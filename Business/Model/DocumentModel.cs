﻿#nullable disable
using DataAccess.Records;
using System.ComponentModel.DataAnnotations;

namespace Business.Model
{
    public class DocumentModel : Record
    {
        [Required]

        public string Name { get; set; }

        public int AppointmentId { get; set; }

        public string DocumentPath { get; set; }
    }
}