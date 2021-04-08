using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] {3.4, 4.5, 4.8, 2.1};
            //List<double> grades = new List<double>();
            var grades = new List<double>() {3.4, 4.5, 4.8, 2.1};
            grades.Add(3.7);
            
            var result = 0.0;
            foreach(var number in numbers){
                
                result += number;
            }
            result /= grades.Count;

            Console.WriteLine($"The average grade is {result}");

            //Console.WriteLine($"Hello, {args[0]}!");
        }
    }
}
