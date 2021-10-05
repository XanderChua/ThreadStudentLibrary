using System;
using System.Collections.Generic;
using System.Text;

namespace ThreadStudentLibrary
{
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        private List<Book> _bookIssued;
        public List<Book> BookIssued
        {
            get
            {
                if(_bookIssued == null)
                {
                    _bookIssued = new List<Book>();
                }
                return _bookIssued;
            }
            private set
            {
                _bookIssued = value;
            }
        }
        public Student(int id, string name)
        {
            StudentID = id;
            StudentName = name;
        }
    }
}
