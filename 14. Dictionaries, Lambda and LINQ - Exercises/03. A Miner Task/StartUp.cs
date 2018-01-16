namespace _03.A_Miner_Task
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var resource = string.Empty;
            var quantity = 0L;
            var resourcesAndQuantity = new Dictionary<string, long>();

            while (true)
            {
                resource = Console.ReadLine();

                if (resource == "stop")
                {
                    break;
                }

                quantity = long.Parse(Console.ReadLine());

                if (resourcesAndQuantity.ContainsKey(resource))
                {
                    var valuePair = resourcesAndQuantity[resource];
                    resourcesAndQuantity[resource] = valuePair + quantity;
                }
                else
                {
                    resourcesAndQuantity[resource] = quantity;
                }
            }

            foreach (var kvp in resourcesAndQuantity)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}