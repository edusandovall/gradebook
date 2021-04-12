using System;
using System.Collections.Generic;

namespace Gradebook {

    class Book {

        private List<double> grades; //This is a field not a variable

        //Constructor
        public Book(){
            grades = new List<double>();
        }

        internal void showStatistics()
        {
            throw new NotImplementedException();
        }

        public void addGrade(double grade){
            grades.Add(grade);
        }
    }
 }