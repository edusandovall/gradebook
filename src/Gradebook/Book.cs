using System;
using System.Collections.Generic;

namespace Gradebook 
{
    public class Book 
    {
        private List<double> grades;
        private string name; 

        //Constructor
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        //Shows average, max and low grade of a set of data
        public Statistics getStatistics()
        {
            var result = new Statistics(); 
            result.average = 0.0;
            result.highGrade= double.MinValue;
            result.lowGrade= double.MaxValue;

            foreach(var grade in grades)
            {
                result.lowGrade= Math.Min(grade, result.lowGrade);
                result.highGrade= Math.Max(grade, result.highGrade);
                result.average += grade;
            }
            result.average /= grades.Count;
            return result; 
        }

        public void addGrade(double grade)
        {
            grades.Add(grade);
        }
    }
 }