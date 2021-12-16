using System;

namespace hospitalGQL.GraphQL.Prescriptions
{
    public record AddPrescriptionInput(string name_prescription, long quantity,DateTime expiration_date);

}

