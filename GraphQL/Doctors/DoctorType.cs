using System.Linq;
using hospitalGQL.Data;
using hospitalGQL.Models;
using HotChocolate;
using HotChocolate.Types;
namespace hospitalGQL.GraphQL.Doctors
{
    public class DoctorType : ObjectType<Doctor>
    {
        protected override void Configure(IObjectTypeDescriptor<Doctor> descriptor)
        {
            descriptor.Description("Represent the patient that has a doctor");

            descriptor
                .Field(d => d.cpr_doctor)
                .Description("Represents the unique ID for the doctor.");

            descriptor
                .Field(d => d.cpr_doctor)
                .Description("Represents the name for the doctor.");

         

            descriptor
                .Field(d => d.Patients)
                .ResolveWith<Resolvers>(d => d.GetPatients(default!, default!))
                .UseDbContext<AppDbContext>()
                .Description("This is the list of available doctor for this patient.");
        }

        private class Resolvers
        {
            public IQueryable<Patient> GetPatients(Doctor doctor, [ScopedService] AppDbContext context)
            {
                return context.Patients.Where(p => p.DoctorId == doctor.cpr_doctor);
            }
        }
    }
}