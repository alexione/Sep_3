package com.example.resthospital.Doctor;

import com.fasterxml.jackson.annotation.JsonProperty;

public class Doctor
{
  @JsonProperty("cpr_doctor")
  int cpr_doctor;

  @JsonProperty("doctor_name")
  String doctor_name;

  @JsonProperty("doctor_age")
  int doctor_age;

  @JsonProperty("speciality")
  String speciality;

  @JsonProperty("city")
  String city;

  @JsonProperty("gender")
  String gender;

  @JsonProperty("house_number")
  int house_number;

  @JsonProperty("street")
  String street;

  @JsonProperty("postal_code")
  int postal_code;

  @JsonProperty("phone")
  int phone;

}


