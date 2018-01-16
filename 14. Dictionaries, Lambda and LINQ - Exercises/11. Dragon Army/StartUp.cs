namespace _11.Dragon_Army
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var data = new Dictionary<string, SortedDictionary<string, int[]>>();
            var pattern = @"([a-zA-Z]*)\s*([a-zA-Z]*)\s*(null|\d+)\s*(null|\d+)\s*(null|\d+)";
            var regex = new Regex(pattern);
            var n = int.Parse(Console.ReadLine());

            for (var i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var match = regex.Match(input);

                if (match.Success)
                {
                    var type = match.Groups[1].Value;
                    var name = match.Groups[2].Value;
                    var damage = 0;
                    var health = 0;
                    var armor = 0;

                    damage = match.Groups[3].Value == "null" ? 45 : int.Parse(match.Groups[3].Value);
                    health = match.Groups[4].Value == "null" ? 250 : int.Parse(match.Groups[4].Value);
                    armor = match.Groups[5].Value == "null" ? 10 : int.Parse(match.Groups[5].Value);

                    if (!data.ContainsKey(type))
                    {
                        data.Add(type, new SortedDictionary<string, int[]>());
                    }

                    if (!data[type].ContainsKey(name))
                    {
                        data[type][name] = new int[3];
                    }

                    data[type][name][0] = damage;
                    data[type][name][1] = health;
                    data[type][name][2] = armor;
                }
            }

            foreach (var outerPair in data)
            {
                Console.WriteLine($"{outerPair.Key}::(" +
                    $"{outerPair.Value.Select(x => x.Value[0]).Average():F}/" +
                    $"{outerPair.Value.Select(x => x.Value[1]).Average():f}/" +
                    $"{outerPair.Value.Select(x => x.Value[2]).Average():f})");

                foreach (var inner in outerPair.Value)
                {
                    Console.WriteLine($"-{inner.Key} -> damage: {inner.Value[0]}," +
                        $" health: {inner.Value[1]}, armor: {inner.Value[2]}");
                }
            }
        }
    }
}