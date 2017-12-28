namespace _08.Refactor_Volume_of_Pyramid
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double length, width, heigth = 0;

            Console.Write("Length: ");
            length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            heigth = double.Parse(Console.ReadLine());

            var volume = (length * width * heigth) / 3.0;
            Console.WriteLine("Pyramid Volume: {0:F2}", volume);
        }
    }
}