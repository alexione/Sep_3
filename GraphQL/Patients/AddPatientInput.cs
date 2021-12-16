using System;
using System.ComponentModel.DataAnnotations;

namespace hospitalGQL.GraphQL.Patients
{
    public record AddPatientInput (long cpr_patient, string patient_name, string blood_type, long house_number , string street,long postal_code,
        string city,long phone, string gender, DateTime  last_update, string patient_status ,long doctorId,long roomID)
    {
        
    }
}

