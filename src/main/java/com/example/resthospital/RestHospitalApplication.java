package com.example.resthospital;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

import java.io.IOException;

@SpringBootApplication
public class RestHospitalApplication {

	//public static HttpURLConnection connection;
	public static void main(String[] args)
			throws IOException, InterruptedException
	{
	 SpringApplication.run(RestHospitalApplication.class, args);
		/*BufferedReader reader;
		String line;
		StringBuffer responseContent = new StringBuffer();

		try
		{
			URL url = new URL("http://jsonplaceholder.typicode.com/albums");
			connection = (HttpURLConnection) url.openConnection();

			//request setup
       connection.setRequestMethod("GET");
       connection.setConnectTimeout(5000);
       connection.setReadTimeout(5000);
       int status= connection.getResponseCode();
       if (status > 299){
       	reader = new BufferedReader(new InputStreamReader(connection.getErrorStream()));
       	while ((line = reader.readLine()) != null){
       		responseContent.append(line);
				}
       	reader.close();
			 }else {
       	reader = new BufferedReader(new InputStreamReader(connection.getErrorStream()));
				 while ((line = reader.readLine()) != null){
					 responseContent.append(line);
				 }
				 reader.close();
			 }
       System.out.println(responseContent.toString());
		}
		catch (MalformedURLException e)
		{
			e.printStackTrace();
		}
		catch (IOException e)
		{
			e.printStackTrace();
		}finally
		{
			connection.disconnect();
		}
*/

	/*	HttpClient client = HttpClient.newHttpClient();
		HttpRequest request = HttpRequest.newBuilder().uri(URI.create("http://localhost:5000/graphql")).build();
		client.sendAsync(request, HttpResponse.BodyHandlers.ofString())
				.thenApply(HttpResponse::body)
				.thenAccept(System.out::println)
				.header("Content-Type", "application/json")
				.join();*/

/*
		HttpRequest request = HttpRequest.newBuilder()
				.uri(URI.create("http://localhost:5000/graphql"))
				.header("Content-Type", "application/json")
				.method("POST", HttpRequest.BodyPublishers.ofString("{\"query\":\"query  getDoctor {\\n  doctor {\\n      cpr_doctor\\n    \\n  }\\n}\",\"operationName\":\"getDoctor\"}"))
				.build();
		HttpResponse<String> response = HttpClient.newHttpClient().send(request, HttpResponse.BodyHandlers.ofString());
		System.out.println(response.body());
*/

	}

}