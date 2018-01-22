namespace _05.Folder_Size
{
    using System;
    using System.IO;

    public class StartUp
    {
        public static void Main()
        {
            if (!File.Exists("../../Size of Files in MB.txt"))
            {
                var file = File.Create("../../Size of Files in MB.txt");
                file.Close();
            }

            var files = Directory.GetFiles("../../TestFolder");
            var sum = 0D;

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                sum += fileInfo.Length;
            }

            sum = (sum / 1024) / 1024;
            File.WriteAllText("../../Size of Files in MB.txt", sum.ToString());
        }
    }
}