using System;
using System.ComponentModel.DataAnnotations;

namespace blazor_hospital.Models
{
    public class PatientMod
    {
        public string cpr_patient { get; set; }

        
        public string patient_name { get; set; }
        public string blood_type { get; set; }
        public string house_number { get; set; }
        public string street { get; set; }
        public string postal_code { get; set; }
        public string city { get; set; }
        public string phone { get; set; }
        public string gender { get; set; }
        public string last_update { get; set; }
        public string patient_status { get; set; }
        public string doctorId { get; set; }
        public string roomID { get; set; }

    
    }
}