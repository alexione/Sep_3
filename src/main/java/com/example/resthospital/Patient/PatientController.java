package com.example.resthospital.Patient;


import com.fasterxml.jackson.databind.DeserializationFeature;
import com.fasterxml.jackson.databind.JsonNode;
import com.fasterxml.jackson.databind.ObjectMapper;
import org.springframework.web.bind.annotation.*;

import java.io.IOException;
import java.net.URI;
import java.net.http.HttpClient;
import java.net.http.HttpRequest;
import java.net.http.HttpResponse;
import java.util.Arrays;
import java.util.List;
import java.util.concurrent.atomic.AtomicLong;

@RestController public class PatientController
{
  private static final String template = "hello, %s!";
  private final AtomicLong counter = new AtomicLong();

  public PatientController() throws IOException, InterruptedException
  {
  }


  @GetMapping("/patients")
  public List<Patient> response()
      throws IOException, InterruptedException
  {

    String query = "{\"query\":\"query  GetPatient {\\n  patient {\\n  cpr_patient,\\n    patient_name,\\n    blood_type,\\n    house_number,\\n    street,\\n    postal_code,\\n    city,\\n    phone,\\n    gender,\\n    last_update,\\n    patient_status\\n    \\n  }\\n}\",\"operationName\":\"GetPatient\"}";
    String response = (String) this.runQuery(query).body();
    ObjectMapper mapper = new ObjectMapper();
    JsonNode node = mapper.readTree(response);
    mapper.configure(DeserializationFeature.FAIL_ON_UNKNOWN_PROPERTIES, false);
    JsonNode responses = node.get("data").get("patient");

    List<Patient> ppl2 = Arrays
        .asList(mapper.readValue(responses.toString(), Patient[].class));

    System.out.println("\nJSON array to List of objects");
    ppl2.stream().forEach(x -> System.out.println(x));
    return ppl2;
  }

  @PostMapping("/patients")
  public Patient newPatient(@RequestBody Patient patient)
      throws IOException, InterruptedException
  {
    ObjectMapper mapper = new ObjectMapper();

    String query =  "{\"query\":\"mutation {\\n  addPatient(\\n    input: {\\n      "
        + "cpr_patient: " + patient.cpr_patient + "\\n"
        + "patient_name: \\\"" + patient.patient_name + "\\\"\\n"
        + "blood_type: \\\"" + patient.blood_type + "\\\"\\n"
        + "house_number: " + patient.house_number + "\\n"
        + "street: \\\"" + patient.street + "\\\"\\n"
        + "postal_code: " + patient.postal_code + "\\n"
        + "city: \\\"" + patient.city + "\\\"\\n"
        + "phone: " + patient.phone + "\\n"
        + "gender: \\\"" + patient.gender + "\\\"\\n"
        + "last_update:  \\\"" + patient.last_update + "\\\"\\n"
        + "patient_status: \\\"" + patient.patient_status + "\\\"\\n"
        + "doctorId: " + patient.doctorId + "\\n"
        + "roomID: " + patient.roomID + "\\n"
        + "}\\n  ) {\\n    patient {\\n      cpr_patient\\n      patient_name\\n      blood_type\\n      house_number\\n      street\\n      postal_code\\n      city\\n      phone\\n      gender\\n      last_update\\n      patient_status\\n    }\\n  }\\n}\\n\"}";

    String response = (String) this.runQuery(query).body();


    JsonNode node = mapper.readTree(response);
    mapper.configure(DeserializationFeature.FAIL_ON_UNKNOWN_PROPERTIES, false);
    JsonNode responses = node.get("data").get("patient");
    return patient;
  }

  @GetMapping("/patients/{id}")
  public JsonNode searchPatient(@PathVariable("id") String id)
      throws IOException, InterruptedException
  {
    ObjectMapper mapper = new ObjectMapper();

    String query ="{\"query\":\"query{\\n  patient(where:{cpr_patient:{eq:" + id + "} })\\n    {\\n      cpr_patient\\n      patient_name\\n      blood_type\\n      house_number\\n      street\\n      postal_code\\n      city\\n      phone\\n      gender\\n      last_update\\n      patient_status\\n    }\\n}\"}";

    String response = (String) this.runQuery(query).body();


    JsonNode node = mapper.readTree(response);
    mapper.configure(DeserializationFeature.FAIL_ON_UNKNOWN_PROPERTIES, false);
    JsonNode responses = node.get("data").get("patient");
    return responses;
  }


/*  @PostMapping("/patients")
  public List<Patient> responseInsert()
      throws IOException, InterruptedException
  {

*//*
    String query = "{\"query\":\"query  GetPatient {\\n  patient {\\n  cpr_patient,\\n    patient_name,\\n    blood_type,\\n    house_number,\\n    street,\\n    postal_code,\\n    city,\\n    phone,\\n    gender,\\n    last_update,\\n    patient_status\\n    \\n  }\\n}\",\"operationName\":\"GetPatient\"}";
    String response = (String) this.runQuery(query).body();
    ObjectMapper mapper = new ObjectMapper();
    JsonNode node = mapper.readTree(response);
    mapper.configure(DeserializationFeature.FAIL_ON_UNKNOWN_PROPERTIES, false);
    JsonNode responses = node.get("data").get("patient");

    List<Patient> ppl2 = Arrays
        .asList(mapper.readValue(responses.toString(), Patient[].class));
*//*

    System.out.println("\nJSON array to List of objects");
    ppl2.stream().forEach(x -> System.out.println(x));
    return ppl2;
  }*/




  private HttpResponse runQuery(String query) throws IOException, InterruptedException
  {
    HttpRequest request = HttpRequest.newBuilder()
        .uri(URI.create("http://localhost:5000/graphql"))
        .header("Content-Type", "application/json").method("POST",
            HttpRequest.BodyPublishers.ofString(
                query))
        .build();
    HttpResponse<String> response = HttpClient.newHttpClient()
        .send(request, HttpResponse.BodyHandlers.ofString());

    return response;
  }
}

