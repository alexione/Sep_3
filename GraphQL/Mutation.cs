using System;
using System.Threading.Tasks;
using hospitalGQL.Data;
using hospitalGQL.GraphQL.Doctors;
using hospitalGQL.GraphQL.Patients;
using hospitalGQL.GraphQL.Prescriptions;
using hospitalGQL.GraphQL.Rooms;
using hospitalGQL.Migrations;
using hospitalGQL.Models;
using HotChocolate;
using HotChocolate.Data;



namespace hospitalGQL.GraphQL
{
    public class Mutation
    {
        [UseDbContext(typeof(AppDbContext))]
        public async Task<AddPatientPayload> AddPatientAsync(AddPatientInput input,
            [ScopedService] AppDbContext context)
        {
            var patient = new Patient
            {
                cpr_patient = input.cpr_patient,
                patient_name = input.patient_name,
                blood_type = input.blood_type,
                house_number = input.house_number,
                street = input.street,
                postal_code = input.postal_code,
                city = input.city,
                phone = input.phone,
                gender = input.gender,
                last_update = input.last_update,
                patient_status = input.patient_status,
                DoctorId = input.doctorId,
                RoomID = input.roomID
            };
            context.Patients.Add(patient);
            await context.SaveChangesAsync();

            return new AddPatientPayload(patient);
        }


        [UseDbContext(typeof(AppDbContext))]
        public async Task<AddDoctorPayload> AddDoctorAsync(AddDoctorInput input,
            [ScopedService] AppDbContext context)
        {
            var doctor = new Doctor
            {
                doctor_name = input.doctor_name,
                doctor_age = input.doctor_age,
                speciality = input.speciality,
                city = input.city,
                gender = input.gender,
                house_number = input.house_number,
                street = input.street,
                postal_code = input.postal_code,
                phone = input.phone
            };
            context.Doctors.Add(doctor);
            await context.SaveChangesAsync();
            return new AddDoctorPayload(doctor);
        }


        [UseDbContext(typeof(AppDbContext))]
        public async Task<AddPrescriptionPayload> AddPrescriptionAsync(AddPrescriptionInput input,
            [ScopedService] AppDbContext context)
        {
            var prescription = new Prescription
            {
                name_prescription = input.name_prescription,
                quantity = input.quantity,
                expiration_date = input.expiration_date
            };
            context.Prescriptions.Add(prescription);
            await context.SaveChangesAsync();
            return new AddPrescriptionPayload(prescription);
        }


        [UseDbContext(typeof(AppDbContext))]
        public async Task<AddRoomPayload> AddRoomAsync(AddRoomInput input,
            [ScopedService] AppDbContext context)
        {
            var room = new Room
            {
                room_type = input.room_type,
                status = input.status
            };

            context.Rooms.Add(room);
            await context.SaveChangesAsync();
            return new AddRoomPayload(room);
        }
    }
}