using System.Linq;
using hospitalGQL.Data;
using hospitalGQL.Models;
using HotChocolate;
using HotChocolate.Types;

namespace hospitalGQL.GraphQL.Prescriptions
{
    public class PrescriptionType : ObjectType<Prescription>
    {
        protected override void Configure(IObjectTypeDescriptor<Prescription> descriptor)
        {
            descriptor.Description("Represents any Prescription.");
            
            descriptor
                .Field(c => c.Patient)
                .ResolveWith<Resolvers>(c => c.GetPatient(default!, default!))
                .UseDbContext<AppDbContext>()
                .Description("This is the Prescription to which the Patient belongs.");

            
        }
        private class Resolvers
        {
            public Patient GetPatient(Prescription prescription, [ScopedService] AppDbContext context)
            {
                return context.Patients.FirstOrDefault(p => p.cpr_patient == prescription.PatientID);
            }
        }
    }
}