namespace _06.Book_Library_Modification
{
    using System;
    using System.Collections.Generic;

    public class Library
    {
        private string name;
        private List<Book> books;

        public Library(string name, List<Book> books)
        {
            this.name = name;
            this.books = books;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = value;
            }
        }

        public List<Book> Books
        {
            get
            {
                return this.books;
            }
            private set
            {
                this.books = value;
            }
        }
    }
}