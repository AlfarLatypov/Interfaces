/*Тема: Интерфейсы.

1.	Создать интерфейс IStudent: 
●	string Name { get; set; }
●	string FullName { get; set; }
●	int[] Grades { get; set; }
●	String GetName()
●	String GetFullName() 
●	Double GetAvgGrade() 
Наследовать от интерфейса класс Student и реализовать его.
*/

using Interfaces.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Alfar", "Latypov");
            string name = student.GetName(), fullName = student.GetFullName();
            double avgGrade = student.GetAvgGrade();
            Console.WriteLine("\n\n\t------------------------------\n\tName: {0}. \n\tFull name: {1}. \n\tAverage grade: {2}.", name, fullName, avgGrade);
            Console.WriteLine("\t------------------------------\n\n\n");
        }
    }
}
