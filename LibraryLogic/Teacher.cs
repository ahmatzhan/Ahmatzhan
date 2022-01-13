using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogic
{
    class Teacher : UserLibrary
    {
        public Teacher() : base()
        {
            Name = "Преподаватель";
            Rating = 13;
        }
        public Teacher(string name, int rating) : base(name, rating)
        {

        }
    }
}
