using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryLogic;

namespace LibraryVisual
{
    public partial class LibraryForm : Form
    {
        List<Book> books = new List<Book>();
        List<UserLibrary> users = new List<UserLibrary>();
        public LibraryForm()
        {
            InitializeComponent();
            fillExample();
        }
        private void fillExample()
        {
            books.Add(new Book("Математика", 10));
            books.Add(new Book("Философия", 13));
            books.Add(new Book("Геометрия", 10));
            books.Add(new Book("Нейросети", 14));

            users.Add(new Student("Студент 1", 12));
            users.Add(new Student("Студент 2", 11));

            users.Add(new Aspirant("Аспирант 1",15));
            users.Add(new Aspirant("Аспирант 2", 16));


            users.Add(new Teacher("Учитель 1", 14));
            users.Add(new Teacher("Учитель 2", 14));


            foreach(Book book in books)
            {
                AllBookComboBox.Items.Add(book.Name);
            }

            foreach (UserLibrary user in users)
            {
                usersComboBox.Items.Add(user.Name);
            }

        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            String status = "Не просрочена";
            if(AllBookComboBox.Text.Length>0 && usersComboBox.Text.Length > 0)
            {
                Book addBook = new Book();
                foreach(Book book in books)
                {
                    if (AllBookComboBox.Text.Equals(book.Name))
                    {
                        addBook = book;
                        break;
                    }
                }
              
                foreach(UserLibrary user in users)
                {
                    if (usersComboBox.Text.Equals(user.Name))
                    {
                        if (user.Rating > addBook.Rating)
                        {
                            addBook.Time = dateTimePicker1.Value;
                            user.AddBook(addBook);                            
                            status = user.CheckBook(addBook);
                            books.Remove(addBook);
                            dataGridView1.Rows.Add(AllBookComboBox.Text, usersComboBox.Text, dateTimePicker1.Value, status);
                            usersComboBox.Text = "";
                            AllBookComboBox.Text = "";
                        }
                        break;
                    }
                }
                updateComboBox();
            }
        }

        public void updateComboBox()
        {
            AllBookComboBox.Items.Clear();
            foreach (Book book in books)
            {
                AllBookComboBox.Items.Add(book.Name);
            }

        }

        private void RemoveBookButton_Click(object sender, EventArgs e)
        {

        }

        private void UpdateBox_Click(object sender, EventArgs e)
        {
           
        }
    }
}
