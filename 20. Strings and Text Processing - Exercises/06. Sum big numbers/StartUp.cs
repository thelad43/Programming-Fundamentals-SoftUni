namespace _06.Sum_big_numbers
{
    using System;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            var firstNumber = Console.ReadLine().TrimStart('0');
            var secondNumber = Console.ReadLine().TrimStart('0');

            if (firstNumber.Length > secondNumber.Length)
            {
                secondNumber = secondNumber.PadLeft(firstNumber.Length, '0');
            }
            else
            {
                firstNumber = firstNumber.PadLeft(secondNumber.Length, '0');
            }

            var sum = 0;
            var numberInMind = 0;
            var remainder = 0;
            var result = new StringBuilder();

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                sum = int.Parse(firstNumber[i].ToString()) + int.Parse(secondNumber[i].ToString()) + numberInMind;
                numberInMind = sum / 10;
                remainder = sum % 10;
                result.Append(remainder);

                if (i == 0 && numberInMind != 0)
                {
                    result.Append(numberInMind);
                }
            }

            var resultInCharArray = result.ToString().ToCharArray();
            Array.Reverse(resultInCharArray);
            Console.WriteLine(new string(resultInCharArray));
        }
    }
}