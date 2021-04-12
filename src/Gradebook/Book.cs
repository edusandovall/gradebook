using System;
using System.Collections.Generic;

namespace Gradebook 
{
    class Book 
    {
        private List<double> grades; 

        //Constructor
        public Book()
        {
            grades = new List<double>();
        }

        //Shows average, max and low grade of a set of data
        public void showStatistics()
        {
            double result = 0.0;
            double highGrade= double.MinValue;
            double lowGrade= double.MaxValue;

            foreach(var number in grades)
            {
                lowGrade= Math.Min(number, lowGrade);
                highGrade= Math.Max(number, highGrade);
                result += number;
            }
            result /= grades.Count;

            Console.WriteLine($"The lowest grade is {lowGrade:N1}");
            Console.WriteLine($"The highest grade is {highGrade:N1}");
            Console.WriteLine($"The average grade is {result:N1}");

        }

        public void addGrade(double grade)
        {
            grades.Add(grade);
        }
    }
 }