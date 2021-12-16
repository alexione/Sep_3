using System;
using System.ComponentModel.DataAnnotations;
namespace blazor_hospital.Models

{
    public class PatientModel
    {
        [Required]
        [StringLength(10, ErrorMessage = "Name is too long.")]
        public long cpr_patient { get; set; }

        
        public string patient_name { get; set; }
        public string blood_type { get; set; }
        public long house_number { get; set; }
        public string street { get; set; }
        public long postal_code { get; set; }
        public string city { get; set; }
        public long phone { get; set; }
        public string gender { get; set; }
        public DateTime last_update { get; set; }
        public string patient_status { get; set; }
        public long doctorId { get; set; }
        public long roomID { get; set; }

    
    }
}