namespace _04.Average_Grades
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            ReadStudents()
                .Where(s => s.AvgGrade >= 5)
                .OrderBy(s => s.Name)
                .ThenByDescending(s => s.AvgGrade)
                .ToList()
                .ForEach(s => Console.WriteLine($"{s.Name} -> {s.AvgGrade:F2}"));
        }

        private static Student[] ReadStudents()
        {
            var n = int.Parse(Console.ReadLine());
            var students = new Student[n];

            for (int i = 0; i < n; i++)
            {
                var inputParams = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var name = inputParams[0];

                var grades = inputParams
                    .Skip(1)
                    .Select(double.Parse)
                    .ToList();

                students[i] = new Student(name, grades, grades.Average());
            }

            return students;
        }
    }
}