using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazor_hospital.Models
{
    public class DoctorModel
    {
       
        public long cpr_doctor { get; set; }

        
        public string doctor_name { get; set; }
       
        public long doctor_age{ get; set; }
      
        public string speciality { get; set; }
     
        public string city  { get; set; }
        
        public string gender  { get; set; }
        
        public long house_number { get; set; }
       
        public string street  { get; set; }
       
        public long postal_code  { get; set; }
        
        public long phone  { get; set; }
   
    }
}