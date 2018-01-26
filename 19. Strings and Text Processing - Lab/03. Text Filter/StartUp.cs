﻿namespace _03.Text_Filter
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var bannedWords = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            var text = Console.ReadLine();

            foreach (var banWord in bannedWords)
            {
                text = text.Replace(banWord, new string('*', banWord.Length));
            }

            Console.WriteLine(text);
        }
    }
}