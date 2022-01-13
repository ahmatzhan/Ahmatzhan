using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogic
{
    public class Aspirant : UserLibrary
    {
        public Aspirant() : base()
        {
            Name = "Аспирант";
            Rating = 15;
        }
        public Aspirant(string name, int rating) : base(name, rating)
        {

        }
    }
}
