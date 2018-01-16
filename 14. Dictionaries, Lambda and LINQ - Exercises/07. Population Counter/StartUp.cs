namespace _07.Population_Counter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var countriesData = new Dictionary<string, Dictionary<string, long>>();

            while (inputLine != "report")
            {
                var inputParams = inputLine.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                var city = inputParams[0];
                var country = inputParams[1];
                var population = long.Parse(inputParams[2]);

                if (!countriesData.ContainsKey(country))
                {
                    countriesData[country] = new Dictionary<string, long>();
                }

                if (!countriesData[country].ContainsKey(city))
                {
                    countriesData[country][city] = 0;
                }

                countriesData[country][city] = population;
                inputLine = Console.ReadLine();
            }

            foreach (var country in countriesData.OrderByDescending(c => c.Value.Values.Sum()))
            {
                var totalPopulation = country.Value.Values.Sum();
                Console.WriteLine($"{country.Key} (total population: {totalPopulation})");

                foreach (var city in country.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}