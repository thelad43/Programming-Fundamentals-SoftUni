namespace _06.User_Logs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var userLogs = new SortedDictionary<string, Dictionary<string, int>>();

            while (inputLine != "end")
            {
                var inputParams = inputLine.Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);
                var ip = inputParams[1];
                var user = inputParams[5];

                if (!userLogs.ContainsKey(user))
                {
                    userLogs[user] = new Dictionary<string, int>();
                }

                if (!userLogs[user].ContainsKey(ip))
                {
                    userLogs[user][ip] = 1;
                }
                else
                {
                    userLogs[user][ip]++;
                }

                inputLine = Console.ReadLine();
            }

            foreach (var user in userLogs)
            {
                Console.WriteLine($"{user.Key}: ");

                foreach (var log in user.Value)
                {
                    if (log.Key != user.Value.Keys.Last())
                    {
                        Console.Write($"{log.Key} => {log.Value}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{log.Key} => {log.Value}.");
                    }
                }
            }
        }
    }
}