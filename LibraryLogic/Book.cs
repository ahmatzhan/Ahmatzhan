using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogic
{
    public class Book
    {
        string name;
        DateTime time;
        string message;
        int rating;
        public Book()
        {

        }
        public Book(string name, DateTime time, string message, int rating)
        {
            Name = name;
            Time = time;
            Message = message;
            Rating = rating;
        }
        public Book(string name,DateTime time, int rating)
        {
            Name = name;
            Time = time;
            Rating = rating;
        }
        public Book(string name, int rating)
        {
            Name = name;
            Rating = rating;
        }
        public string Name { get => name; set => name = value; }
        public DateTime Time { get => time; set => time = value; }
        public string Message { get => message; set => message = value; }
        public int Rating { get => rating; set => rating = value; }
    }
}
