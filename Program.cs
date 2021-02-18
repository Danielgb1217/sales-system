using System;

namespace sales_system
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            // products instances 
            Product product1 = new Product("Computer", 3000000);
            Product product2 = new Product("laptop", 2000000);
            Product product3 = new Product("desk", 500000);

            //sellers instances
            Seller seller1 = new Seller("Daniel", 27);
            Seller seller2 = new Seller("Andres", 30);
            Seller seller3 = new Seller("Alejandra", 24);

            //sales instances
            Sale sale1 = new Sale(product1, seller2, "computer hp");
            Sale sale2 = new Sale(product2, seller1, "laptop  Asus");
            Sale sale3 = new Sale(product3, seller3, "white desk");


          
            System.Console.WriteLine("Total Sales: " + (product1.getPrice() + product2.getPrice() + product3.getPrice()) );

        }


     

    }
}
