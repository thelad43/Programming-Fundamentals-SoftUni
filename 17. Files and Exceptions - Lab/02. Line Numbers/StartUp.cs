namespace _02.Line_Numbers
{
    using System;
    using System.IO;
    using System.Text;

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

            StringBuilder numberedLines = new StringBuilder(allLines.Length);

            for (int i = 0; i < allLines.Length; i++)
            {
                numberedLines.Append(i + 1);
                numberedLines.AppendLine($". {allLines[i]}");
            }

            File.WriteAllLines("../../Output.txt", numberedLines.ToString().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries));
        }
    }
}