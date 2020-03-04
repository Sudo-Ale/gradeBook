using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        public Book(string name)   //costruttore
        {
            grades = new List<double>();
        }
        public void AddGrade(double grade)
        {
            //List<double> grades; NO, questo non è un campo, ma una variabile locale.
            grades.Add(grade);
        }

        //SI, questo è un campo, e Book se lo porterà con sè per il resto della sua vita.
        public List<double> grades = new List<double>(); 
    }
}