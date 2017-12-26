namespace _13.Game_of_Numbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var magicalNumber = int.Parse(Console.ReadLine());

            var counter = 0;
            var firstDigit = 0;
            var secondDigit = 0;
            var magicalNumberFound = false;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    counter++;

                    if (i + j == magicalNumber)
                    {
                        firstDigit = i;
                        secondDigit = j;
                        magicalNumberFound = true;
                    }
                }
            }

            if (magicalNumberFound)
            {
                Console.WriteLine($"Number found! {firstDigit} + {secondDigit} = {magicalNumber}");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicalNumber}");
            }
        }
    }
}