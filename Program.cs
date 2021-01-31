using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Brand = "Mavi";
            product1.Price = 336;
            product1.Button = "Kalp";
            product1.FreeCargo = "Cargo is free";
            product1.BasketDiscount = 45;

            Product product2 = new Product();
            product2.Brand = "Lufian";
            product2.Price = 449;
            product2.Button = "Kalp";
            product2.FreeCargo = "Cargo is not free";
            product2.BasketDiscount = 15;

            Product product3 = new Product();
            product3.Brand = "Avva";
            product3.Price = 885;
            product3.Button = "Kalp";
            product3.FreeCargo = "Cargo is free";
            product3.BasketDiscount = 33;

            Product[] products = new Product[] {product1, product2, product3 };

            Console.WriteLine("----------------FOR----------------");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(products[i].Brand + " " +products[i].Price + " " +products[i].Button + " " +products[i].FreeCargo + " " +products[i].BasketDiscount);
            }

            Console.WriteLine("----------------FOREACH----------------");

            foreach (var item in products)
            {
                Console.WriteLine(item.Brand + " " + item.Price + " " + item.Button + " " + item.FreeCargo + " " + item.BasketDiscount);
            }

            Console.WriteLine("----------------WHILE----------------");

            int kosul = 0;

            while (kosul < 3)
            {
                Console.WriteLine(products[kosul].Brand + " " + products[kosul].Price + " " + products[kosul].Button + " " + products[kosul].FreeCargo + " " + products[kosul].BasketDiscount);
                kosul++;
            }
           
        }
    }
}
