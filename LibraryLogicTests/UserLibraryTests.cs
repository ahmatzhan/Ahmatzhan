using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryLogic;

namespace LibraryLogic.Tests
{
    [TestClass()]
    public class UserLibraryTests
    {
        [TestMethod()]
        public void AddStudentBookTest()
        {
            Student student = new Student();
            student.AddBook(new Book("Математика", 10));
            Assert.IsTrue(student.Book[0].Name.Equals("Математика"));
        }
        [TestMethod()]
        public void RemoveStudentBookTest()
        {
            Student student = new Student();
            Book book = new Book("Математика", 10);
            Book bookTwo = new Book("Русский", 10);
            student.AddBook(book);
            student.AddBook(bookTwo);
            student.ReturnBook(book);
            Assert.AreEqual(student.Book[0].Name,"Русский");
        }
        [TestMethod()]
        public void TimeBookTest()
        {
            Student student = new Student();
            Book book = new Book("Математика", new DateTime(2021, 5, 10), 10);
            student.AddBook(book);
            Assert.AreEqual(student.CheckBook(book), "Просрочена");
        }
        [TestMethod()]
        public void TimeBookTest2()
        {
            Student student = new Student();
            Book book = new Book("Математика", new DateTime(2023, 5, 10), 10);
            student.AddBook(book);
            Assert.AreEqual(student.CheckBook(book), "Не просрочена");
        }

        [TestMethod()]
        public void RatingTest()
        {
            Student student = new Student();
            student.AddBook(new Book("Философия", 12));
            Assert.AreEqual(student.Book.Count, 0);
        }
    }
}