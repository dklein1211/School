using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST_Book_HW
{
    class Book
    {
        internal string title { get; set; }
        internal string author { get; set; }
        internal int rating { get; set; }
        internal int year { get; set; }

        public Book(string t, string a, int r, int y)
        {
            title = t;
            author = a;
            rating = r;
            year = y;
        }

        public Book()
        {
            title = "No Such Book";
            author = "";
            rating = 0;
            year = 0;
        }
    }
}
