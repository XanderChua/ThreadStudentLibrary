using System;

namespace ThreadStudentLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Thread Library--");           
            ThreadClass threadClass = new ThreadClass();
            threadClass.CallThread();
        }
    }
}
