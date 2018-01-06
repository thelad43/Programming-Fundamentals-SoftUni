namespace _07.Sum_Arrays
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var firstArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            var secondArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            if (firstArr.Length != secondArr.Length)
            {
                MakeArraysExactLength(ref firstArr, ref secondArr);
            }

            var sumArrays = new int[firstArr.Length];

            for (int i = 0; i < firstArr.Length; i++)
            {
                sumArrays[i] = firstArr[i] + secondArr[i];
            }

            Console.WriteLine($"{string.Join(" ", sumArrays)}");
        }

        private static void MakeArraysExactLength(ref int[] firstArr, ref int[] secondArr)
        {
            var index = 0;
            var indexOfLastElement = 0;

            if (firstArr.Length > secondArr.Length)
            {
                var cuurentLengthOfSecondArray = secondArr.Length;
                indexOfLastElement = secondArr.Length - 1;
                index = 0;
                Array.Resize(ref secondArr, firstArr.Length);

                for (int i = 0; i < firstArr.Length - cuurentLengthOfSecondArray; i++)
                {
                    secondArr[indexOfLastElement + 1] = secondArr[index];
                    indexOfLastElement++;
                    index++;
                }
            }
            else
            {
                var cuurentLengthOfFirstArray = firstArr.Length;
                indexOfLastElement = firstArr.Length - 1;
                index = 0;
                Array.Resize(ref firstArr, secondArr.Length);

                for (int i = 0; i < secondArr.Length - cuurentLengthOfFirstArray; i++)
                {
                    firstArr[indexOfLastElement + 1] = firstArr[index];
                    indexOfLastElement++;
                    index++;
                }
            }
        }
    }
}