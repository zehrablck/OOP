namespace lab_5
{
    using System;
    using System.Linq;

    class Product
    {
        private double price;

        public string ProductCode { get; init; }

        public string Name { get; set; }

        public double Price
        {
            get => price;
            set
            {
                if (value > 0)
                {
                    price = value;
                }
                else
                {
                    Console.WriteLine($"Invalid price: {value}");
                    price = 1.0;
                }
            }
        }

        public int Stock { get; private set; }

        public Product(string productCode, string name, double price, int stock)
        {
            ProductCode = productCode;
            Name = name;
            Price = price;
            Stock = stock;
        }

        public void Restock(int amount)
        {
            if (amount > 0)
            {
                Stock += amount;
            }
        }

        public string Info()
        {
            return $"[{ProductCode}] {Name} - ${Price:F2} (Stock: {Stock})";
        }
    }

    class Program
    {
        static void Main()
        {
            Product[] products =
            {
            new Product("P101", "Wireless Mouse", 25.50, 15),
            new Product("P102", "Mechanical Keyboard", 85.00, 10),
            new Product("P103", "USB-C Cable", -15, 50),
            new Product("P104", "Gaming Monitor", 220.00, 5)
        };

   
            foreach (Product product in products)
            {
                Console.WriteLine(product.Info());
            }

            double[] prices = products.Select(p => p.Price).ToArray();

            Console.WriteLine();

            Console.WriteLine($"Min Price: {prices.Min()}");
            Console.WriteLine($"Max Price: {prices.Max()}");
            Console.WriteLine($"Average: {prices.Average():F2}");
            Console.WriteLine($"Products >= 50: {prices.Count(p => p >= 50)}");

            double[] sortedPrices = (double[])prices.Clone();
            Array.Sort(sortedPrices);

            Console.Write("Sorted Prices: ");
            foreach (double price in sortedPrices)
            {
                Console.Write(price + " ");
            }

            Console.WriteLine();

            int index = Array.BinarySearch(sortedPrices, 85);

            if (index >= 0)
                Console.WriteLine($"Binary Search for 85: Found at Index {index}");
            else
                Console.WriteLine("Binary Search for 85: Not Found");
        }
    }
}