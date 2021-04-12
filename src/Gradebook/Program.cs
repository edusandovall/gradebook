using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.addGrade(4.5);
            book.addGrade(3.5);
            book.addGrade(2.9);
            book.addGrade(3.7);
            book.showStatistics();
        }
    }
}
