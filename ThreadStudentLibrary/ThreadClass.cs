using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace ThreadStudentLibrary
{
    class ThreadClass
    {
        Collection<Student> listStudent = new Collection<Student>();
        Collection<Book> listBook = new Collection<Book>();
        public void CallThread()
        {           
            bool loop = true;
            while (loop)
            {

                Console.WriteLine("1. Issue book");
                Console.WriteLine("2. Add student");
                Console.WriteLine("3. Add book");
                Console.WriteLine("4. Remove student");
                Console.WriteLine("5. Remove book");
                Console.WriteLine("6. List all students");
                Console.WriteLine("7. List all available books");
                Console.WriteLine("8. Exit");
                int input = Int32.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        {
                            ThreadStart start = new ThreadStart(IssueBook);
                            Thread t1 = new Thread(start);
                            t1.Start();
                            t1.Join();
                            break;
                        }
                    case 2:
                        {
                            //Thread t2 = new Thread(() => { listStudent.addCollection(new Student(studentId, studentName)); });
                            ThreadStart start = new ThreadStart(AddStudent);
                            Thread t2 = new Thread(start);
                            t2.Start();
                            t2.Join();
                            break;
                        }
                    case 3:
                        {
                            //Thread t3 = new Thread(() => { listBook.addCollection(new Book(bookId, bookName)); });
                            ThreadStart start = new ThreadStart(AddBook);
                            Thread t3 = new Thread(start);
                            t3.Start();
                            t3.Join();
                            break;
                        }
                    case 4:
                        {
                            ThreadStart start = new ThreadStart(RemoveStudent);
                            Thread t4 = new Thread(start);
                            t4.Start();
                            t4.Join();
                            break;
                        }
                    case 5:
                        {
                            ThreadStart start = new ThreadStart(RemoveBook);
                            Thread t5 = new Thread(start);
                            t5.Start();
                            t5.Join();
                            break;
                        }
                    case 6:
                        {
                            //Thread t6 = new Thread(() => { ListStudents(); });
                            ThreadStart start = new ThreadStart(ListStudents);
                            Thread t6 = new Thread(start);
                            t6.Start();
                            t6.Join();
                            break;
                        }
                    case 7:
                        {
                            ThreadStart start = new ThreadStart(ListBooks);
                            Thread t7 = new Thread(start);
                            t7.Start();
                            t7.Join();
                            break;
                        }
                    case 8:
                        {
                            loop = false;
                            break;
                        }
                }
            }
        }
        public void IssueBook()
        {
            Console.WriteLine("Enter your name:");
            string yourName = Console.ReadLine();
            Student studentObj = null;
            foreach (Student s in listStudent.CollectionObj)
            {
                if (string.Equals(yourName, s.StudentName))
                {
                    studentObj = s;
                }
            }
            if (studentObj != null)
            {
                Console.WriteLine("Select book to borrow:");
                foreach (Book b in listBook.CollectionObj)
                {
                    Console.WriteLine(listBook.CollectionObj.IndexOf(b) + 1 + ". " + b.BookName);
                }
                int bookSelect = Int32.Parse(Console.ReadLine());
                studentObj.BookIssued.Add(listBook[bookSelect - 1]);
                listBook.removeCollection(listBook[bookSelect - 1]);
                Console.WriteLine("Borrow Success!");
            }
            else
            {
                Console.WriteLine(yourName + " does not exist.");
            }
        }
        public void AddStudent()
        {
            Console.WriteLine("Enter student id:");
            int studentId = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter student name:");
            string studentName = Console.ReadLine();
            listStudent.addCollection(new Student(studentId, studentName));
        }       
        public void AddBook()
        {
            Console.WriteLine("Enter book id:");
            int bookId = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter book name:");
            string bookName = Console.ReadLine();
            listBook.addCollection(new Book(bookId, bookName));
        }
        public void RemoveStudent()
        {
            Console.WriteLine("Select student to remove:");
            ListStudents();
            int studentSelect = Int32.Parse(Console.ReadLine());
            listStudent.removeCollection(listStudent[studentSelect - 1]);
            Console.WriteLine("Book removed!");
        }
        public void RemoveBook()
        {
            Console.WriteLine("Select book to remove:");
            ListBooks();
            int bookSelect = Int32.Parse(Console.ReadLine());
            listBook.removeCollection(listBook[bookSelect - 1]);
            Console.WriteLine("Book removed!");
        }
        public void ListStudents()
        {
            foreach (var student in listStudent.CollectionObj)
            {
                Console.WriteLine(listStudent.CollectionObj.IndexOf(student) + 1 + ". ID: " + student.StudentID + " Name: " + student.StudentName);
            }
        }
        public void ListBooks()
        {
            foreach (var book in listBook.CollectionObj)
            {
                Console.WriteLine(listBook.CollectionObj.IndexOf(book) + 1 + ". ID: " + book.BookID + " Name: " + book.BookName);
            }
        }
    }
}
