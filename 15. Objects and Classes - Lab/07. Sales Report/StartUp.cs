namespace _07.Sales_Report
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var sales = new Sale[n];

            for (int i = 0; i < n; i++)
            {
                sales[i] = ReadSale();
            }

            var result = new SortedDictionary<string, decimal>();

            foreach (var sale in sales)
            {
                if (result.ContainsKey(sale.Town))
                {
                    result[sale.Town] += sale.Price * (decimal)sale.Quantity;
                }
                else
                {
                    result[sale.Town] = sale.Price * (decimal)sale.Quantity;
                }
            }

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:F2}");
            }
        }

        private static Sale ReadSale()
        {
            var saleTokens = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var town = saleTokens[0];
            var product = saleTokens[1];
            var price = decimal.Parse(saleTokens[2]);
            var quantity = double.Parse(saleTokens[3]);

            return new Sale(town, product, price, quantity);
        }
    }
}