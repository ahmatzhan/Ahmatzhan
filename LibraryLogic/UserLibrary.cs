using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogic
{
    public abstract class UserLibrary
    {
        string name;
        int rating;
        List<Book> book;
        public UserLibrary()
        {
            book = new List<Book>();
        }
        public UserLibrary(string name,int rating)
        {
            Name = name;
            Rating = rating;
            book = new List<Book>();
        }
        public void AddBook(Book book)
        {
            if (book.Rating < Rating)
            {
                Book.Add(book);
            }
        }

        public void ReturnBook(Book book)
        {
            Book.Remove(book);
        }

        public string CheckBook(Book book)
        {
            return DateTime.Now > book.Time ? "Просрочена" : "Не просрочена";
        }

        public List<Book> Book { get => book; set => book = value; }
        public string Name { get => name; set => name = value; }
        public int Rating { get => rating; set => rating = value; }
    }
}
