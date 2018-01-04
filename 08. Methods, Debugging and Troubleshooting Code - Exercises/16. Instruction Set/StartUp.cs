namespace _16.Instruction_Set
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var opCode = Console.ReadLine().ToUpper();
            long result = 0;

            while (opCode != "END")
            {
                var codeArgs = opCode.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                switch (codeArgs[0])
                {
                    case "INC":
                        {
                            var operandOne = long.Parse(codeArgs[1]);
                            result = operandOne + 1;
                            break;
                        }

                    case "DEC":
                        {
                            var operandOne = long.Parse(codeArgs[1]);
                            result = operandOne - 1;
                            break;
                        }

                    case "ADD":
                        {
                            var operandOne = long.Parse(codeArgs[1]);
                            var operandTwo = long.Parse(codeArgs[2]);
                            result = operandOne + operandTwo;
                            break;
                        }

                    case "MLA":
                        {
                            var operandOne = long.Parse(codeArgs[1]);
                            var operandTwo = long.Parse(codeArgs[2]);
                            result = operandOne * operandTwo;
                            break;
                        }
                }

                Console.WriteLine(result);
                opCode = Console.ReadLine().ToUpper();
            }
        }
    }
}