using System;

namespace CG_Practice.dsascenario.BookBuddy
{
    class Book
    {
        private string title;
        private string author;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        public override string ToString()
        {
            return $"{title} - {author}";
        }
    }
}
