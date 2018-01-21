using System.Collections.Generic;

namespace _07.Andrey_and_Billiard
{
    public class Customer
    {
        private string name;
        private Dictionary<string, int> boughtProducts;
        private decimal bill;

        public Customer()
        {
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public Dictionary<string, int> BoughtProducts
        {
            get
            {
                return this.boughtProducts;
            }
            set
            {
                this.boughtProducts = value;
            }
        }

        public decimal Bill
        {
            get
            {
                return this.bill;
            }
            set
            {
                this.bill = value;
            }
        }
    }
}