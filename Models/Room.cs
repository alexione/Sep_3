using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HotChocolate;
using Microsoft.EntityFrameworkCore;

namespace hospitalGQL.Models
{
    public class Room
    {
        [Key] 
        public long room_number { get; set; }
        public string room_type { get; set; }
        public string status { get; set; }
   
            

        public ICollection<Patient> Patients { get; set; } = new List<Patient>();
        
    }
}