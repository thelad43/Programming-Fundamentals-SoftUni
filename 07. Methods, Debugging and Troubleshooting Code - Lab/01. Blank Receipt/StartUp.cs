namespace _01.Blank_Receipt
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            PrintBlankCashReceipt();
        }

        private static void PrintBlankCashReceipt()
        {
            PrintingHeader();
            PrintBody();
            PrintFooter();
        }

        private static void PrintFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© SoftUni");
        }

        private static void PrintBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        private static void PrintingHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
    }
}