using System;
using System.Linq;
using hospitalGQL.Data;
using hospitalGQL.Models;
using HotChocolate;
using HotChocolate.Data;

namespace hospitalGQL.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(AppDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Patient> GetPatient([ScopedService] AppDbContext context)
        {
            return context.Patients;
        }
        [UseDbContext(typeof(AppDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Doctor> GetDoctor([ScopedService] AppDbContext context)
        {
          //Console.WriteLine(context.Doctors);
            return context.Doctors;
        }
        
        [UseDbContext(typeof(AppDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Room> GetRoom([ScopedService] AppDbContext context)
        {
            return context.Rooms;
        }
        
        
        [UseDbContext(typeof(AppDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Prescription> GetPrescription([ScopedService] AppDbContext context)
        {
            return context.Prescriptions;
        }
    }
}
    