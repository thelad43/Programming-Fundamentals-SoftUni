namespace _09.Book_Library
{
    using System;

    public class Book
    {
        private string title;
        private string author;
        private string publisher;
        private DateTime releaseDate;
        private string ISBNNumber;
        private decimal price;

        public Book(string title, string author, string publisher, DateTime releaseDate,
            string iSBNNumber, decimal price)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.releaseDate = releaseDate;
            this.ISBNNumber = iSBNNumber;
            this.price = price;
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            private set
            {
                this.title = value;
            }
        }

        public string Author
        {
            get
            {
                return this.author;
            }
            private set
            {
                this.author = value;
            }
        }

        public string Publisher
        {
            get
            {
                return this.publisher;
            }
            private set
            {
                this.publisher = value;
            }
        }

        public DateTime ReleaseDate
        {
            get
            {
                return this.releaseDate;
            }
            private set
            {
                this.releaseDate = value;
            }
        }

        public string ISBNNumber1
        {
            get
            {
                return this.ISBNNumber;
            }
            private set
            {
                this.ISBNNumber = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                this.price = value;
            }
        }
    }
}