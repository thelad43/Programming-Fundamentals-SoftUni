namespace _06.Interval_of_Numbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());

            if (firstNum > secondNum)
            {
                var oldValue = firstNum;
                firstNum = secondNum;
                secondNum = oldValue;
            }

            for (int i = firstNum; i <= secondNum; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}