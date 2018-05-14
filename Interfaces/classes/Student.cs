using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.classes
{
    class Student : IStudent
    {
        private Random rand = new Random();
        public Student(string _Name, string _FullName)
        {
            Name = _Name;
            FullName = _FullName;
            Grades = new int[rand.Next(4, 10)];
            for (int i = 0; i < Grades.Length; i++)
            {
                Grades[i] = rand.Next(1, 12);
            }
        }
        public string Name { get; set; }
        public string FullName { get; set; }
        public int[] Grades { get; set; }

        public double GetAvgGrade()
        {
            int a = 0;
            for (int i = 0; i < Grades.Length; i++)
            {
                a += Grades[i];
            }
            return (double)a / (double)Grades.Length;
        }

        public string GetFullName()
        {
            return FullName;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
