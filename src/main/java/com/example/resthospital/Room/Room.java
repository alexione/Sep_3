package com.example.resthospital.Room;

import com.fasterxml.jackson.annotation.JsonProperty;

public class Room
{

  @JsonProperty("room_number")
  int room_number;

  @JsonProperty("room_type")
  String room_type;

  @JsonProperty("status")
  String status;




}
