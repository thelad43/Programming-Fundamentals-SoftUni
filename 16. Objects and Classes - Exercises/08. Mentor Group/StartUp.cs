namespace _08.Mentor_Group
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var students = new SortedDictionary<string, Student>();
            var format = "dd/MM/yyyy";

            while (inputLine != "end of dates")
            {
                var inputParams = inputLine
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var name = inputParams[0];
                var dates = new List<DateTime>();

                if (inputParams.Length > 1)
                {
                    var dateSequance = inputParams[1]
                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < dateSequance.Length; i++)
                    {
                        var currentDate = DateTime.ParseExact(dateSequance[i], format,
                            CultureInfo.InvariantCulture);

                        dates.Add(currentDate);
                    }
                }

                var student = new Student
                {
                    Name = name
                };

                if (!students.ContainsKey(name))
                {
                    students.Add(name, student);
                    student.AttendanceDates = dates;
                }
                else
                {
                    students[name].AttendanceDates.AddRange(dates);
                }

                inputLine = Console.ReadLine();
            }

            inputLine = Console.ReadLine();

            while (inputLine != "end of comments")
            {
                var commentsInfo = inputLine
                    .Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

                var name = commentsInfo[0];
                var comment = commentsInfo[1];
                var comments = new List<string>
                {
                    comment
                };

                if (students.ContainsKey(name))
                {
                    if (students[name].Comments != null)
                    {
                        students[name].Comments.AddRange(comments);
                    }
                    else
                    {
                        students[name].Comments = comments;
                    }
                }

                inputLine = Console.ReadLine();
            }

            PrintStudents(students, format);
        }

        private static void PrintStudents(SortedDictionary<string, Student> students, string format)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key}{Environment.NewLine}Comments:");

                if (student.Value.Comments != null)
                {
                    foreach (var comment in student.Value.Comments)//
                    {
                        Console.WriteLine($"- {comment}");
                    }
                }

                Console.WriteLine($"Dates attended:");

                foreach (var date in student.Value.AttendanceDates.OrderBy(d => d))
                {
                    Console.WriteLine($"-- {date.ToString(format, CultureInfo.InvariantCulture)}");
                }
            }
        }
    }
}