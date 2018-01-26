namespace _01.Reverse_String
{
    using System;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            var textForReversing = Console.ReadLine();
            var reversed = ReverseString(textForReversing);
            Console.WriteLine(reversed);
        }

        private static string ReverseString(string textForReversing)
        {
            var sb = new StringBuilder(textForReversing.Length);

            for (int i = textForReversing.Length - 1; i >= 0; i--)
            {
                sb.Append(textForReversing[i]);
            }

            return sb.ToString();
        }
    }
}