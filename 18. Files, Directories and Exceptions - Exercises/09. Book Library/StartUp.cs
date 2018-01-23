namespace _09.Book_Library
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var books = ReadBooks();
            var library = new Library("Library", books);
            var salesByAuthor = new Dictionary<string, decimal>();

            foreach (var author in books.Select(x => x.Author).Distinct())
            {
                salesByAuthor.Add(author, books.Where(x => x.Author == author)
                                               .Select(x => x.Price)
                                               .Sum());
            }

            var result = new List<string>();

            foreach (var kvp in salesByAuthor
                                .OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                result.Add($"{kvp.Key} -> {kvp.Value:f2}");
            }

            if (!File.Exists("../../output.txt"))
            {
                var file = File.Create("../../output.txt");
                file.Close();
            }

            File.WriteAllLines("../../output.txt", result);
        }

        private static List<Book> ReadBooks()
        {
            var bookData = File.ReadAllLines("../../input.txt");
            var books = new List<Book>();

            for (int i = 0; i < bookData.Length; i++)
            {
                var bookTokens = bookData[i]
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var format = "dd.MM.yyyy";
                var title = bookTokens[0];
                var author = bookTokens[1];
                var publisher = bookTokens[2];
                var releaseDate = DateTime.ParseExact(bookTokens[3], format, CultureInfo.InvariantCulture);
                var ISBNNumber = bookTokens[4];
                var price = decimal.Parse(bookTokens[5]);

                var book = new Book(title, author, publisher, releaseDate, ISBNNumber, price);
                books.Add(book);
            }

            return books;
        }
    }
}