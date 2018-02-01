namespace _04.Anonymous_Cache
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var data = new Dictionary<string, Dictionary<string, long>>();
            var cache = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "thetinggoesskrra")
                {
                    break;
                }

                var inputParameters = inputLine
                    .Split(" ->|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                if (inputParameters.Length == 1)
                {
                    var dataSet = inputParameters[0];

                    if (cache.ContainsKey(dataSet))
                    {
                        data[dataSet] = new Dictionary<string, long>(cache[dataSet]);
                        cache.Remove(dataSet);
                    }
                    else
                    {
                        data[dataSet] = new Dictionary<string, long>();
                    }
                }
                else
                {
                    var dataKey = inputParameters[0];
                    var dataSize = long.Parse(inputParameters[1]);
                    var dataSet = inputParameters[2];

                    if (!data.ContainsKey(dataSet))
                    {
                        if (!cache.ContainsKey(dataSet))
                        {
                            cache[dataSet] = new Dictionary<string, long>();
                        }

                        cache[dataSet][dataKey] = dataSize;
                    }
                    else
                    {
                        data[dataSet][dataKey] = dataSize;
                    }
                }
            }

            if (data.Count > 0)
            {
                var result = data
                    .OrderByDescending(ds => ds.Value.Sum(d => d.Value))
                    .FirstOrDefault();

                Console.WriteLine($"Data Set: {result.Key}, Total Size: {result.Value.Sum(d => d.Value)}");
                var prefix = "$.";

                foreach (var value in result.Value)
                {
                    Console.WriteLine($"{prefix}{value.Key}");
                }
            }
        }
    }
}