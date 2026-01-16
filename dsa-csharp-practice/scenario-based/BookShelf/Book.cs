using System;

namespace CG_Practice.oopsscenario.BookShelf
{
    public class Book
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
            return $"Title: {Title}, Author: {Author}";
        }

        public override int GetHashCode()
        {
            return Title.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Book other = obj as Book;
            if (other == null) return false;
            return this.Title.Equals(other.Title);
        }
    }
}
