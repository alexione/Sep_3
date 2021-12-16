using System.Collections.Generic;
using System.Linq;
using hospitalGQL.Data;
using HotChocolate.Types;
using hospitalGQL.Models;
using HotChocolate;
using HotChocolate.Configuration;
using HotChocolate.Types.Descriptors.Definitions;
using Microsoft.EntityFrameworkCore;

namespace hospitalGQL.GraphQL.Patients
{
    public class PatientType : ObjectType<Patient>
    {
        protected override void Configure(IObjectTypeDescriptor<Patient> descriptor)
        {
            descriptor.Description("Represents any Patient.");

            descriptor
                .Field(c => c.cpr_patient)
                .Description("Represents the unique ID for the Patient.");

            descriptor
                .Field(c => c.patient_name)
                .Description("Represents the name for the Patient.");

            descriptor
                .Field(c => c.blood_type)
                .Description("Represents the blood type for the Patient.");

            descriptor
                .Field(c => c.gender)
                .Description("Represents the gender for the Patient.");

            descriptor
                .Field(c => c.Doctor)
                .ResolveWith<Resolvers>(c => c.GetDoctor(default!, default!))
                .UseDbContext<AppDbContext>()
                .Description("This is the Doctor to which the Patient belongs.");

        }
            
        
    private class Resolvers
        {
            public Doctor GetDoctor(Patient patient, [ScopedService] AppDbContext context)
            {
                return context.Doctors.FirstOrDefault(p => p.cpr_doctor == patient.DoctorId);
            }
        }
    }
}