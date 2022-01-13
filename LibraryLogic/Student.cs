using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogic
{
    class Student : UserLibrary
    {
        public Student():base()
        {
            Name = "Студент";
            Rating = 10;
        }
        public Student(string name, int rating) : base(name,rating)
        {
            
        }
        
    }
}
