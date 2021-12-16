package com.example.resthospital.Room;

import com.fasterxml.jackson.databind.DeserializationFeature;
import com.fasterxml.jackson.databind.JsonNode;
import com.fasterxml.jackson.databind.ObjectMapper;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

import java.io.IOException;
import java.net.URI;
import java.net.http.HttpClient;
import java.net.http.HttpRequest;
import java.net.http.HttpResponse;
import java.util.Arrays;
import java.util.List;
import java.util.concurrent.atomic.AtomicLong;

@RestController public class RoomController
{
  private static final String template = "hello, %s!";
  private final AtomicLong counter = new AtomicLong();

  public RoomController() throws IOException, InterruptedException
  {
  }


  @GetMapping("/rooms")
  public List<Room> response()
      throws IOException, InterruptedException
  {

    String query = "{\"query\":\"query  GetRoom {\\n  room {\\n room_number,\\n    room_type,\\n    status\\n    \\n  }\\n}\",\"operationName\":\"GetRoom\"}";
    String response = (String) this.runQuery(query).body();
    ObjectMapper mapper = new ObjectMapper();
    JsonNode node = mapper.readTree(response);
    mapper.configure(DeserializationFeature.FAIL_ON_UNKNOWN_PROPERTIES, false);
    JsonNode responses = node.get("data").get("room");

    List<Room> ppl2 = Arrays
        .asList(mapper.readValue(responses.toString(), Room[].class));

    System.out.println("\nJSON array to List of objects");
    ppl2.stream().forEach(x -> System.out.println(x));
    return ppl2;
  }

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
