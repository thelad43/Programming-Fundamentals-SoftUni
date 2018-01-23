namespace _08.Average_Grades
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var students = ReadStudents();

            students = students
                .Where(x => x.AvgGrade >= 5)
                .OrderBy(x => x.Name)
                .ThenBy(x => -x.AvgGrade)
                .ToList();

            StudentsToFile(students);
        }

        private static void StudentsToFile(List<Student> students)
        {
            if (!File.Exists("../../output.txt"))
            {
                var file = File.Create("../../output.txt");
                file.Close();
            }

            File.WriteAllLines("../../output.txt", students.Select(x => $"{x.Name} -> {x.AvgGrade:F2}").ToList());
        }

        private static List<Student> ReadStudents()
        {
            var studentGrades = File.ReadAllLines("../../input.txt");
            var students = new List<Student>();

            for (int i = 0; i < studentGrades.Length; i++)
            {
                var inputParams = studentGrades[i]
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var name = inputParams[0];

                var grades = inputParams
                    .Skip(1)
                    .Select(double.Parse)
                    .ToList();

                students.Add(new Student(name, grades, grades.Average()));
            }

            return students;
        }
    }
}