using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            #region vecchie robe

            /*Sintassi per array in modo statico

            double[] numbers = new double[3];
            var numbers = new double[3];
            numbers[0] = 12.7;
            numbers[1] = 10.3;
            numbers[2] = 6.11;
            */

            //----------
            //Sintassi per array in modo statico, con dimensione dinamica

            //Solo se conosco la dimensione dell'array
            /*
            var result = numbers[0];
            result = result + numbers[1];
            result = result + numbers[2];
            */

            //Solo se conosco la dimensione dell'array, più carino
            /*
            var result = numbers[0];
            result += numbers[1];
            result += numbers[2];
            result += numbers[3];
            */

            //var numbers = new double[] {12.7, 10.3, 6.11, 4.1};            


            #endregion

            //------------------

            var grades = new List<double>() {12.7, 10.3, 6.11, 4.1};    //Lista con indicizzazione iniziale
            grades.Add(56.1);   //con questo gli elementi sono a 5

            //In questo modo è più dinamico, perchè pur non sapendo la dimensione dell'array/lista, posso ottenere il risultato che voglio
            //Ciclare sulla matrice/lista per ogni number in numbers[]/grades<>
            var result = 0.0;
            
            foreach(var number in grades)
            {
                result += number;
            }
            //var resultAverage = result / grades.Count;
            //result /= grades.Count;

            Console.WriteLine($"La somma dei voti è: {result}\nIl numero dei voti è: {grades.Count}\nLa media dei voti è: {result/grades.Count:N1}");

            //-----------------

            /*Book book2 = new Book();
            book2.AddGrade(90.1);*/

            var book = new Book("Scott's Grade Book");
            book.AddGrade(89.1);
            book.grades.Add(101);
        }
    }
}
