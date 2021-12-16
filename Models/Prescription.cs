using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HotChocolate;
using Microsoft.EntityFrameworkCore;

namespace hospitalGQL.Models
{
    public class Prescription
    {
        [Key] 
        public long prescription_id{ get; set; }
        
        public string name_prescription { get; set; }
        public long quantity { get; set; }
        public DateTime expiration_date { get; set; }

        public long PatientID { get; set; }
        public Patient Patient { get; set; }
      
       
    }
}