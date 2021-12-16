package com.example.resthospital.Patient;

import com.fasterxml.jackson.annotation.JsonProperty;

import java.sql.Date;

public class Patient
{

  @JsonProperty("cpr_patient")
  int cpr_patient;

  @JsonProperty("patient_name")
  String patient_name;

  @JsonProperty("blood_type")
  String blood_type;

  @JsonProperty("house_number")
  int house_number;

  @JsonProperty("street")
  String street;

  @JsonProperty("postal_code")
  int postal_code;

  @JsonProperty("city")
  String city;

  @JsonProperty("phone")
  int phone;

  @JsonProperty("gender")
  String gender;

  @JsonProperty("last_update") Date last_update;

  @JsonProperty("patient_status")
  String patient_status;

  @JsonProperty("doctorId")
  int doctorId;

  @JsonProperty("roomID")
  int roomID;

}
