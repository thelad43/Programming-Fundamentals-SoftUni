namespace _01.Largest_Common_End
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var firstArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var secondArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var commonElementsCount = GetLargestCommonEnd(firstArr, secondArr);
            Console.WriteLine(commonElementsCount);
        }

        private static int GetLargestCommonEnd(string[] firstArr, string[] secondArr)
        {
            var rightCount = 0;
            var leftCount = 0;

            while (rightCount < firstArr.Length && rightCount < secondArr.Length)
            {
                if (firstArr[firstArr.Length - rightCount - 1] == secondArr[secondArr.Length - rightCount - 1])
                {
                    rightCount++;
                }
                else
                {
                    break;
                }
            }

            while (leftCount < firstArr.Length && leftCount < secondArr.Length)
            {
                if (firstArr[leftCount] == secondArr[leftCount])
                {
                    leftCount++;
                }
                else
                {
                    break;
                }
            }

            if (rightCount > leftCount)
            {
                return rightCount;
            }

            return leftCount;
        }
    }
}