using System;

namespace blazor_hospital.Models
{
    public class PrescriptionModel
    {
        public long prescription_id{ get; set; }
       public string name_prescription{ get; set; }
        public long quantity{ get; set; }
        public DateTime expiration_date{ get; set; }

    }
}