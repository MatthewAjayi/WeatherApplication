using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WeatherApplication.Models;

namespace WeatherApplication.Controllers
{
    public class WeatherController : ApiController
    {
        private const string ApiKey = "7b99611040ce48b8b67224515232908"; // Replace with your actual API key
        private const string WeatherApiBaseUrl = "http://api.weatherapi.com/v1/forecast.json";

        public async Task<IHttpActionResult> GetWeather(string city)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    int numberOfDays = 6;
                    // Build the URL with the city name and API key
                    string apiUrl = $"{WeatherApiBaseUrl}?key={ApiKey}&q={city}&days={numberOfDays}"; // Adjust units as needed

                    // Send a GET request to the weather API
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        // Deserialize the JSON response into a WeatherData object
                        string json = await response.Content.ReadAsStringAsync();
                        WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(json);

                        return Ok(weatherData);
                    }
                    else
                    {
                        return BadRequest("Error fetching weather data.");
                    }
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
