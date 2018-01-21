namespace _06.Book_Library_Modification
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
            var format = "dd.MM.yyyy";

            var startDate = DateTime.ParseExact(Console.ReadLine(), format,
                CultureInfo.InvariantCulture);

            var library = new Library("Library", books);
            var filteredBooks = new Dictionary<string, DateTime>();

            for (int book = 0; book < library.Books.Count; book++)
            {
                if (!filteredBooks.ContainsKey(library.Books[book].Title))
                {
                    filteredBooks.Add(library.Books[book].Title,
                        library.Books[book].ReleaseDate);
                }
                else
                {
                    filteredBooks[library.Books[book].Title] = library.Books[book].ReleaseDate;
                }
            }

            foreach (var book in filteredBooks.Where(x => x.Value > startDate)
                .OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
                var currentDate = book.Value.ToString(format, CultureInfo.InvariantCulture);
                Console.WriteLine($"{book.Key:f2} -> {currentDate}");
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