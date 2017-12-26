namespace _03.Restaurant_Discount
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var groupSize = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();

            decimal price;
            string hallName;

            if (groupSize <= 50)
            {
                price = 2500;
                hallName = "Small Hall";
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                price = 5000;
                hallName = "Terrace";
            }
            else if (groupSize <= 120)
            {
                price = 7500;
                hallName = "Great Hall";
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            switch (package)
            {
                case "Normal":
                    price += 500;
                    price = price - (price * 0.05M);
                    break;

                case "Gold":
                    price += 750;
                    price = price - (price * 0.10M);
                    break;

                case "Platinum":
                    price += 1000;
                    price = price - (price * 0.15M);
                    break;

                default:
                    throw new ArgumentException();
            }

            var pricePerPerson = price / groupSize;

            Console.WriteLine($"We can offer you the {hallName}");
            Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
        }
    }
}