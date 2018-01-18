namespace _07.Sales_Report
{
    public class Sale
    {
        private string town;
        private string product;
        private decimal price;
        private double quantity;

        public Sale(string town, string product, decimal price, double quantity)
        {
            this.town = town;
            this.product = product;
            this.price = price;
            this.quantity = quantity;
        }

        public string Town
        {
            get
            {
                return this.town;
            }
            private set
            {
                this.town = value;
            }
        }

        public string Product
        {
            get
            {
                return this.product;
            }
            private set
            {
                this.product = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                this.price = value;
            }
        }

        public double Quantity
        {
            get
            {
                return this.quantity;
            }
            private set
            {
                this.quantity = value;
            }
        }
    }
}