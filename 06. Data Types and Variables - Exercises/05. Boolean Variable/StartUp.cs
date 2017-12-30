namespace _05.Boolean_Variable
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            if (Convert.ToBoolean(input))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}