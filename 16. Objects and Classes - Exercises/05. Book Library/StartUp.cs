namespace _05.Book_Library
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
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

            foreach (var kvp in salesByAuthor
                                .OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:f2}");
            }
        }

        private static List<Book> ReadBooks()
        {
            var n = int.Parse(Console.ReadLine());
            var books = new List<Book>(n);

            for (int i = 0; i < n; i++)
            {
                var bookTokens = Console.ReadLine()
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