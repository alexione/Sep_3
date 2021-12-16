namespace hospitalGQL.GraphQL.Doctors
{
    public record AddDoctorInput(string doctor_name, long doctor_age, string speciality, string city, string gender,
        long house_number, string street, long postal_code, long phone);
}

