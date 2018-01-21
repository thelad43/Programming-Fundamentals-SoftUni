namespace _07.Andrey_and_Billiard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var menuItems = AddMenuItems();
            var customers = ReadClients(menuItems);
            PrintResults(customers, menuItems);
        }

        private static List<Customer> ReadClients(Dictionary<string, decimal> menuItems)
        {
            var inputLine = Console.ReadLine();
            var customers = new List<Customer>();

            while (!inputLine.Equals("end of clients"))
            {
                var ordersData = inputLine.Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var item = ordersData[1];
                var clientName = ordersData[0];
                var quantity = int.Parse(ordersData[2]);
                var clientOrders = new Dictionary<string, int>();

                if (!menuItems.ContainsKey(item))
                {
                    inputLine = Console.ReadLine();
                    continue;
                }

                var customer = new Customer();

                if (customers.Any(cl => cl.Name == clientName))
                {
                    customer = customers.First(cl => cl.Name == clientName);

                    if (!customer.BoughtProducts.ContainsKey(item))
                    {
                        customer.BoughtProducts.Add(item, 0);
                    }

                    customer.BoughtProducts[item] += quantity;
                }
                else
                {
                    customer.Name = clientName;

                    customer.BoughtProducts = new Dictionary<string, int>
                    {
                        { item, 0 }
                    };

                    customer.BoughtProducts[item] += quantity;
                    customers.Add(customer);
                }

                inputLine = Console.ReadLine();
            }

            return customers;
        }

        private static void PrintResults(List<Customer> clients, Dictionary<string,
            decimal> menuItems)
        {
            var bills = new List<decimal>();

            foreach (var client in clients.OrderBy(x => x.Name))
            {
                Console.WriteLine(client.Name);

                foreach (var order in client.BoughtProducts)
                {
                    client.Bill += order.Value * menuItems[order.Key];
                    Console.WriteLine($"-- {order.Key} - {order.Value}");
                }

                bills.Add(client.Bill);

                Console.WriteLine($"Bill: {client.Bill:F2}");
            }

            Console.WriteLine($"Total bill: {bills.Sum():F2}");
        }

        private static Dictionary<string, decimal> AddMenuItems()
        {
            var items = new Dictionary<string, decimal>();
            var number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                var itemProp = Console.ReadLine()
                    .Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

                var item = itemProp[0];
                var singlePrice = decimal.Parse(itemProp[1]);

                if (!items.ContainsKey(item))
                {
                    items.Add(item, 0);
                }

                items[item] = singlePrice;
            }

            return items;
        }
    }
}