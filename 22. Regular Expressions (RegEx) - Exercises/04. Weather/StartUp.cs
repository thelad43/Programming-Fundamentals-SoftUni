namespace _04.Weather
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var cities = new Dictionary<string, City>();
            var pattern = @"([A-Z][A-Z])(\d{2}\.\d{1,})([A-Za-z]+[A-Za-z])\|";
            var regex = new Regex(pattern);
            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                foreach (Match match in regex.Matches(inputLine))
                {
                    var name = match.Groups[1].Value;
                    var temperature = (double.Parse(match.Groups[2].Value));
                    var wheather = match.Groups[3].Value;
                    var city = new City(temperature, wheather);
                    cities[name] = (city);
                }

                inputLine = Console.ReadLine();
            }

            foreach (var city in cities.OrderBy(c => c.Value.AverageTemperature))
            {
                Console.WriteLine($"{city.Key} => {city.Value.AverageTemperature:f2} => {city.Value.TypeOfWheather}");
            }
        }
    }

    public class City
    {
        private double averageTemperature;
        private string typeOfWheather;

        public City(double averageTemperature, string typeOfWheather)
        {
            this.AverageTemperature = averageTemperature;
            this.TypeOfWheather = typeOfWheather;
        }

        public double AverageTemperature
        {
            get
            {
                return this.averageTemperature;
            }
            private set
            {
                this.averageTemperature = value;
            }
        }

        public string TypeOfWheather
        {
            get
            {
                return this.typeOfWheather;
            }
            private set
            {
                this.typeOfWheather = value;
            }
        }
    }
}