namespace _04.Merge_Files
{
    using System;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            if (!File.Exists("../../Output.txt"))
            {
                var file = File.Create("../../Output.txt");
                file.Close();
            }

            var allData = File.ReadAllLines("../../FileOne.txt");
            allData = allData.Concat(File.ReadAllLines("../../FileTwo.txt")).ToArray();
            File.WriteAllLines(@"../../Output.txt", allData.OrderBy(x => x));
        }
    }
}