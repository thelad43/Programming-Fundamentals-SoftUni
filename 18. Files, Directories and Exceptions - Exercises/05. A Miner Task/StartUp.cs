namespace _05.A_Miner_Task
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            var resources = new Dictionary<string, long>();
            var allLinesOfInput = File.ReadAllLines("../../input.txt");
            var resource = allLinesOfInput[0];
            resources[resource] = 0;

            for (int i = 1; i < allLinesOfInput.Length; i++)
            {
                if (i % 2 == 0)
                {
                    resource = allLinesOfInput[i];

                    if (resource == "stop")
                    {
                        break;
                    }

                    if (!resources.ContainsKey(resource))
                    {
                        resources[resource] = 0;
                    }
                }
                else
                {
                    resources[resource] += long.Parse(allLinesOfInput[i]);
                }
            }

            ResourcesToFile(resources);
        }

        private static void ResourcesToFile(Dictionary<string, long> resources)
        {
            if (!File.Exists("../../output.txt"))
            {
                var file = File.Create("../../output.txt");
                file.Close();
            }

            var result = new StringBuilder();

            foreach (var resource in resources)
            {
                result.AppendLine($"{resource.Key} -> {resource.Value}");
            }

            File.WriteAllText("../../output.txt", result.ToString());
        }
    }
}