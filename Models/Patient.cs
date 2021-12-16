using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HotChocolate;
using Microsoft.EntityFrameworkCore;

namespace hospitalGQL.Models
{
    
    public class Patient
    {
        [Key] 
        public long cpr_patient { get; set; }
        
        public string patient_name { get; set; }
        public string blood_type { get; set; }
        public long house_number { get; set; }
        public string street { get; set; }
        public long postal_code { get; set; }
        public string city { get; set; }
        public long phone { get; set; }
        public string gender { get; set; }
        public DateTime  last_update { get; set; }
        public string patient_status { get; set; }

        public long cpr_doctor { get; set; }

       public long DoctorId { get; set; }
       
             
       public long RoomID { get; set; }
        public Doctor Doctor { get; set; }
        
  
        public Room Room { get; set; }
        
        public ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();
        
    }
}