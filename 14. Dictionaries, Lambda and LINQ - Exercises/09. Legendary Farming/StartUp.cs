namespace _09.Legendary_Farming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var itemValues = new Dictionary<string, long>
            {
                { "fragments", 0 },
                { "shards", 0 },
                { "motes", 0 }
            };

            var count = 1;

            while (count != 10)
            {
                var inputParams = Console.ReadLine().ToLower().Split();
                var optainedItem = string.Empty;

                for (int i = 1; i < inputParams.Length; i += 2)
                {
                    var materialValue = int.Parse(inputParams[i - 1]);
                    var material = inputParams[i];

                    if (!itemValues.ContainsKey(material))
                    {
                        itemValues.Add(material, 0);
                    }

                    itemValues[material] += materialValue;
                    optainedItem = CheckForLegendery(itemValues);

                    if (optainedItem != string.Empty)
                    {
                        Console.WriteLine($"{optainedItem} obtained!");
                        break;
                    }
                }

                if (optainedItem != string.Empty)
                {
                    break;
                }

                count++;
            }

            PrintAllItems(itemValues);
        }

        private static void PrintAllItems(Dictionary<string, long> itemValues)
        {
            var rareItems = itemValues.Take(3).OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToList();
            var junkItems = itemValues.Skip(3).OrderBy(x => x.Key).ToList();

            foreach (var rareItem in rareItems)
            {
                Console.WriteLine($"{rareItem.Key}: {rareItem.Value}");
            }

            foreach (var junkItem in junkItems)
            {
                Console.WriteLine($"{junkItem.Key}: {junkItem.Value}");
            }
        }

        private static string CheckForLegendery(Dictionary<string, long> itemValues)
        {
            var itemForCrafting = string.Empty;

            if (itemValues["fragments"] >= 250)
            {
                itemForCrafting = "Valanyr";
                itemValues["fragments"] -= 250;
            }

            if (itemValues["shards"] >= 250)
            {
                itemForCrafting = "Shadowmourne";
                itemValues["shards"] -= 250;
            }

            if (itemValues["motes"] >= 250)
            {
                itemForCrafting = "Dragonwrath";
                itemValues["motes"] -= 250;
            }

            return itemForCrafting;
        }
    }
}