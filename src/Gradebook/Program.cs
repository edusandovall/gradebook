using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Eduardo's Gradebook");
            book.addGrade(4.5);
            book.addGrade(3.5);
            book.addGrade(2.9);
            book.addGrade(3.7);
            
            var stats = book.getStatistics();

            Console.WriteLine($"The lowest grade is {stats.lowGrade:N1}");
            Console.WriteLine($"The highest grade is {stats.highGrade:N1}");
            Console.WriteLine($"The average grade is {stats.average:N1}");

        }
    }
}
