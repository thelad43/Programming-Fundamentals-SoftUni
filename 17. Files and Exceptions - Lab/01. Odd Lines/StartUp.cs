namespace _01.Odd_Lines
{
    using System.Collections.Generic;
    using System.IO;

    public class StartUp
    {
        public static void Main()
        {
            var allLines = File.ReadAllLines("../../Input.txt");

            if (!File.Exists("../../Output.txt"))
            {
                var file = File.Create("../../Output.txt");
                file.Close();
            }

            var oddLines = new List<string>();

            for (int i = 0; i < allLines.Length; i++)
            {
                if (i % 2 != 0)
                {
                    oddLines.Add(allLines[i]);
                }
            }

            File.WriteAllLines("../../Output.txt", oddLines);
        }
    }
}