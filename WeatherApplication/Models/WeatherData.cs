using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherApplication.Models
{
    public class WeatherData
    {
        public Location Location { get; set; }
        public Current Current { get; set; }

        public Forecast Forecast { get; set; }
    }

    public class Location
    {
        public string Name { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public string TzId { get; set; }
        public long LocaltimeEpoch { get; set; }
        public string Localtime { get; set; }
    }

    public class Condition
    {
        public string Text { get; set; }
        public string Icon { get; set; }
        public int Code { get; set; }
    }

    public class Current
    {
        public long LastUpdatedEpoch { get; set; }
        public string LastUpdated { get; set; }
        public double Temp_C { get; set; }
        public double Temp_F { get; set; }
        public int IsDay { get; set; }
        public Condition Condition { get; set; }
        public double WindMph { get; set; }
        public double WindKph { get; set; }
        public int WindDegree { get; set; }
        public string WindDir { get; set; }
        public double PressureMb { get; set; }
        public double PressureIn { get; set; }
        public double PrecipMm { get; set; }
        public double PrecipIn { get; set; }
        public int Humidity { get; set; }
        public int Cloud { get; set; }
        public double FeelslikeC { get; set; }
        public double FeelslikeF { get; set; }
        public double VisKm { get; set; }
        public double VisMiles { get; set; }
        public double Uv { get; set; }
        public double GustMph { get; set; }
        public double GustKph { get; set; }
    }

    public class Forecast
    {
        public List<Forecastday> Forecastday { get; set; }
    }

    public class Forecastday
    {
        public string Date { get; set; }
        public Day Day { get; set; }
    }

    public class Day
    {
        public double Maxtemp_c { get; set; }
        public double Maxtemp_f { get; set; }
        public double Mintemp_c { get; set; }
        public double Mintemp_f { get; set; }
        public double Avgtemp_c { get; set; }
        public double Avgtemp_f { get; set; }
        public double Maxwind_mph { get; set; }
        public double Maxwind_kph { get; set; }
        public double Totalprecip_mm { get; set; }
        public double Totalprecip_in { get; set; }
        public double Avgvis_km { get; set; }
        public double Avgvis_miles { get; set; }
        public double Avghumidity { get; set; }
        public Condition Condition { get; set; }
        public double Ultraviolet_index { get; set; }
    }

}