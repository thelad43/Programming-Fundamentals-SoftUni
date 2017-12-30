namespace _06.Strings_And_Objects
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string str1 = "Hello";
            string str2 = "World";
            object obj = str1 + " " + str2;
            string str3 = (string)obj;
            Console.WriteLine(str3);
        }
    }
}