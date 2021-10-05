using System;
using System.Collections.Generic;
using System.Text;

namespace ThreadStudentLibrary
{
    class Book
    {
        public int BookID { get; set; }
        public string BookName { get; set; }     
        public Book(int id, string name)
        {
            BookID = id;
            BookName = name;
        }
    }
}
