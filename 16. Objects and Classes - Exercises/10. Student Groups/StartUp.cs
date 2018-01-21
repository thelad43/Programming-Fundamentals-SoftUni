namespace _10.Student_Groups
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var towns = GetTownData();
            var groups = GetGroups(towns);
            PrintResults(groups);
        }

        private static void PrintResults(List<Group> groups)
        {
            var townsCount = groups
                .Select(x => x.Town)
                .Distinct()
                .Count();

            Console.WriteLine($"Created {groups.Count} groups in {townsCount} towns:");

            foreach (var group in groups.OrderBy(x => x.Town.Name))
            {
                Console.Write($"{group.Town.Name} => ");
                Console.WriteLine($"{string.Join(", ", group.Students.Select(x => x.Email))}");
            }
        }

        private static List<Group> GetGroups(List<Town> towns)
        {
            var groups = new List<Group>();

            foreach (var town in towns.OrderBy(x => x.Name))
            {
                IEnumerable<Student> studs = town
                    .Students
                    .OrderBy(x => x.RegistrationDate)
                    .ThenBy(z => z.Name)
                    .ThenBy(y => y.Email);

                while (studs.Any())
                {
                    var group = new Group
                    {
                        Town = town
                    };

                    group.Students = studs.Take(group.Town.SeatsCount).ToList();
                    studs = studs.Skip(group.Town.SeatsCount);
                    groups.Add(group);
                }
            }

            return groups;
        }

        private static List<Town> GetTownData()
        {
            var towns = new List<Town>();
            var inputLine = Console.ReadLine();

            while (inputLine != "End")
            {
                if (inputLine.Contains("=>"))
                {
                    var town = new Town();
                    var input = Regex.Split(inputLine, @"\s=>\s").ToList();
                    var townName = input[0];
                    var seats = int.Parse(Regex.Match(input[1], @"\d+").Value);

                    town.Name = townName;
                    town.SeatsCount = seats;
                    town.Students = new List<Student>();

                    towns.Add(town);
                }
                else
                {
                    var input = inputLine
                        .Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => x.Trim())
                        .ToList();

                    var student = new Student();
                    var studentName = input[0];
                    var email = input[1];

                    var regDate = DateTime.ParseExact(input[2], "d-MMM-yyyy",
                        CultureInfo.InvariantCulture);

                    student.Name = studentName;
                    student.Email = email;
                    student.RegistrationDate = regDate;

                    towns.LastOrDefault().Students.Add(student);
                }

                inputLine = Console.ReadLine();
            }

            return towns;
        }
    }
}