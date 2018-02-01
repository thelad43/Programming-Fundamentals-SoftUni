namespace _02.Anonymous_Threat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            var stringsForProcessing = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "3:1")
                {
                    break;
                }

                var inputParameters = inputLine.Split();
                var command = inputParameters[0];

                if (command == "merge")
                {
                    var startIndex = int.Parse(inputParameters[1]);
                    var endIndex = int.Parse(inputParameters[2]);

                    stringsForProcessing = Merge(stringsForProcessing, startIndex, endIndex);
                }
                else if (command == "divide")
                {
                    var index = int.Parse(inputParameters[1]);
                    var partitions = int.Parse(inputParameters[2]);

                    stringsForProcessing = Divide(stringsForProcessing, index, partitions);
                }
            }

            Console.WriteLine(string.Join(" ", stringsForProcessing));
        }

        private static int ChangeIndex(int index, int maxLength)
        {
            if (index < 0)
            {
                index = 0;
            }

            if (index >= maxLength)
            {
                index = maxLength - 1;
            }

            return index;
        }

        private static List<string> Merge(List<string> sensitiveData, int startIndex, int endIndex)
        {
            // merge all elements from the startIndex, till the endIndex
            // Example: {abc, def, ghi} -> merge 0 1 -> {abcdef, ghi}

            startIndex = ChangeIndex(startIndex, sensitiveData.Count);
            endIndex = ChangeIndex(endIndex, sensitiveData.Count);

            var newList = new List<string>();

            for (int i = 0; i < startIndex; i++)
            {
                newList.Add(sensitiveData[i]);
            }

            var result = new StringBuilder();

            for (int i = startIndex; i <= endIndex; i++)
            {
                result.Append(sensitiveData[i]);
            }

            newList.Add(result.ToString());

            for (int i = endIndex + 1; i < sensitiveData.Count; i++)
            {
                newList.Add(sensitiveData[i]);
            }

            return newList;
        }

        private static List<string> Divide(List<string> sensitiveData, int index, int partitions)
        {
            // Example: {abcdef, ghi, jkl} -> divide 0 3 -> {ab, cd, ef, ghi, jkl}
            // DIVIDE the element at the given index, into several small substrings with equal length
            // If the string CANNOT be exactly divided into the given partitions, make all partitions except the LAST with EQUAL LENGTHS, and make the LAST one – the LONGEST

            var element = sensitiveData[index];
            var partitionLength = element.Length / partitions;
            var dividedPartitions = new List<string>();

            for (int i = 0; i < partitions; i++)
            {
                if (i == partitions - 1)
                {
                    dividedPartitions.Add(element.Substring(i * partitionLength));
                }
                else
                {
                    dividedPartitions.Add(element.Substring(i * partitionLength, partitionLength));
                }
            }

            sensitiveData.RemoveAt(index);
            sensitiveData.InsertRange(index, dividedPartitions);

            return sensitiveData;
        }
    }
}