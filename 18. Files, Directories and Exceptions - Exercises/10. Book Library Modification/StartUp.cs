namespace _10.Book_Library_Modification
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static DateTime startDateTime = new DateTime();

        public static void Main()
        {
            var format = "dd.MM.yyyy";
            var books = ReadBooks(format);
            var startDate = startDateTime;

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

            var result = new List<string>();

            foreach (var book in filteredBooks.Where(x => x.Value > startDate)
                .OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
                var currentDate = book.Value.ToString(format, CultureInfo.InvariantCulture);
                result.Add($"{book.Key:f2} -> {currentDate}");
            }

            if (!File.Exists("../../output.txt"))
            {
                var file = File.Create("../../output.txt");
                file.Close();
            }

            File.WriteAllLines("../../output.txt", result);
        }

        private static List<Book> ReadBooks(string format)
        {
            var bookData = File.ReadAllLines("../../input.txt");
            var books = new List<Book>();

            startDateTime = DateTime.ParseExact(bookData[bookData.Length - 1], format,
                CultureInfo.InvariantCulture);

            for (int i = 0; i < bookData.Length - 1; i++)
            {
                var bookTokens = bookData[i]
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

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