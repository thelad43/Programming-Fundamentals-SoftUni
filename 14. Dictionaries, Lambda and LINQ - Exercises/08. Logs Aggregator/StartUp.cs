namespace _08.Logs_Aggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var users = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var inputParams = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var ip = inputParams[0];
                var user = inputParams[1];
                var duration = int.Parse(inputParams[2]);

                if (!users.ContainsKey(user))
                {
                    users.Add(user, new SortedDictionary<string, int>());
                }

                if (!users[user].ContainsKey(ip))
                {
                    users[user].Add(ip, duration);
                }
                else
                {
                    users[user][ip] += duration;
                }
            }

            foreach (var user in users)
            {
                var totalDurationOfUser = users[user.Key].Values.Sum();
                var listOfIps = user.Value.Keys.ToList();
                Console.WriteLine($"{user.Key}: {totalDurationOfUser} [{string.Join(", ", listOfIps)}]");
            }
        }
    }
}