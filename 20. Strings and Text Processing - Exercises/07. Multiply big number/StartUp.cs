namespace _07.Multiply_big_number
{
    using System;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            var firstNumber = Console.ReadLine().TrimStart('0');
            var secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber == "0" || secondNumber == 0 || string.IsNullOrEmpty(firstNumber))
            {
                Console.WriteLine(0);
                return;
            }

            var product = 0;
            var numberInMind = 0;
            var remainder = 0;
            var result = new StringBuilder();

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                product = int.Parse(firstNumber[i].ToString()) * secondNumber + numberInMind;
                numberInMind = (product / 10);
                remainder = (product % 10);
                result.Append(remainder);

                if (i == 0 && numberInMind != 0)
                {
                    result.Append(numberInMind);
                }
            }

            var resultToCharArr = result.ToString().ToCharArray();
            Array.Reverse(resultToCharArr);
            Console.WriteLine(new string(resultToCharArr));
        }
    }
}