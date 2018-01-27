namespace _08.Letters_Change_Numbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var inputParams = Console.ReadLine()
                .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            var totalSum = 0D;

            foreach (var word in inputParams)
            {
                if (word.Length > 1)
                {
                    var sum = 0D;
                    var firstIndex = word[0];
                    var secondIndex = word[word.Length - 1];
                    var number = 0D;

                    if (word.Length > 2)
                    {
                        number = double.Parse(word.Substring(1, word.Length - 2));
                    }

                    sum = GetFirstSum(firstIndex, number);
                    sum = GetSecondSum(secondIndex, sum);
                    totalSum += sum;
                }
            }

            Console.WriteLine($"{totalSum:f2}");
        }

        private static double GetSecondSum(char secondIndex, double sum)
        {
            var secondSum = sum;
            var position = GetPosition(secondIndex);

            if (secondIndex >= 'a' && secondIndex <= 'z')
            {
                secondSum += position;
            }
            else if (secondIndex >= 'A' && secondIndex <= 'Z')
            {
                secondSum -= position;
            }

            return secondSum;
        }

        private static double GetFirstSum(char firstIndex, double number)
        {
            var sum = 0D;
            var position = GetPosition(firstIndex);

            if (firstIndex >= 'a' && firstIndex <= 'z')
            {
                sum = number * position;
            }
            else if (firstIndex >= 'A' && firstIndex <= 'Z')
            {
                sum = number / position;
            }

            return sum;
        }

        private static double GetPosition(char index)
        {
            var count = 0;
            var letter = char.ToLower(index);

            for (int i = 'a'; i <= 'z'; i++)
            {
                if (i > letter)
                {
                    break;
                }

                count++;
            }

            return count;
        }
    }
}