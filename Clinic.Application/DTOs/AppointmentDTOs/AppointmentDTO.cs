using Clinic.Core.Entities;
using Clinic.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Application.DTOs.AppointmentDTOs
{
    public class AppointmentDTO : BaseDTO
    {
        [Required]
        public Guid DoctorId { get; set; }

        [Required]
        public Guid PatientId { get; set; }

        [Required]
        public Guid DoctorScheduleId { get; set; }

        [Required]
        public Guid AppointmentTypeId { get; set; }

        [Required]
        public DateOnly AppointmentDate { get; set; }

        [Required]
        public AppointmentStatus AppointmentStatus { get; set; }
    }
}
