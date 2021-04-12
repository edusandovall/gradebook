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
            book.showStatistics();
           
            var grades = new List<double>() {3.4, 4.5, 4.8, 2.1};
            grades.Add(4.9);
            
            var result = 0.0;
            foreach(var grade in grades){
                
                result += grade;
            }
            result /= grades.Count;

            Console.WriteLine($"The average grade is {result}");

            //Console.WriteLine($"Hello, {args[0]}!");
        }
    }
}
