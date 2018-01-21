using System.Collections.Generic;

namespace _04.Average_Grades
{
    public class Student
    {
        private string name;
        private List<double> grades;
        private readonly double avgGrade;

        public Student(string name, List<double> grades, double avgGrade)
        {
            this.name = name;
            this.grades = grades;
            this.avgGrade = avgGrade;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = value;
            }
        }

        public List<double> Grades
        {
            get
            {
                return this.grades;
            }
            private set
            {
                this.grades = value;
            }
        }

        public double AvgGrade
        {
            get
            {
                return this.avgGrade;
            }
        }
    }
}