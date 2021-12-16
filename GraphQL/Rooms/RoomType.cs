using System.Linq;
using hospitalGQL.Data;
using hospitalGQL.Models;
using HotChocolate;
using HotChocolate.Types;

namespace hospitalGQL.GraphQL.Rooms
{
    public class RoomType: ObjectType<Room>
    {
        protected override void Configure(IObjectTypeDescriptor<Room> descriptor)
        {
            descriptor.Description("Represents any Room.");
            
            descriptor
                .Field(d => d.Patients)
                .ResolveWith<Resolvers>(d => d.GetPatients(default!, default!))
                .UseDbContext<AppDbContext>()
                .Description("This is the list of available room for this patient.");
        }
        private class Resolvers
        {
            public IQueryable<Patient> GetPatients(Room room, [ScopedService] AppDbContext context)
            {
                return context.Patients.Where(p => p.RoomID == room.room_number);
            }
        }
    }
}