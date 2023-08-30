using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Results;
using System.Web.Http;
using System.Web.Mvc;
using WeatherApplication.Controllers;
using WeatherApplication.Models;
using System.Threading.Tasks;
using HttpPostAttribute = System.Web.Mvc.HttpPostAttribute;

namespace WeatherApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            //var weatherData = new WeatherController().GetWeather("Brampton");

            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Index(string searchInput)
        {
            var weatherController = new WeatherController();
            IHttpActionResult weatherActionResult = await weatherController.GetWeather(searchInput);

            if (weatherActionResult is OkNegotiatedContentResult<WeatherData>)
            {
                var weatherData = ((OkNegotiatedContentResult<WeatherData>)weatherActionResult).Content;
                return View(weatherData);
            }

            else
            {
                // Handle the case where the weather API response is not successful
                //string errorMessage = "Error fetching weather data.";
                return View("Invalid"); // Return the error view with the error message
            }
        }
    }
}
