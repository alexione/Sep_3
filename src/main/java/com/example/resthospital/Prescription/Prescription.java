package com.example.resthospital.Prescription;

import com.fasterxml.jackson.annotation.JsonProperty;

public class Prescription
{
  @JsonProperty("prescription_id") int prescription_id;

  @JsonProperty("price") float price;

  @JsonProperty("quantity") int quantity;

  @JsonProperty("expiration_date") int expiration_date;

  @JsonProperty("cpr_patient") int cpr_patient;

}
