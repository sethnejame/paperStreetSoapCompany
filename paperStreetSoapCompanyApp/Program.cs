using System;

namespace paperStreetSoapCompanyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ProductRepository myProdRepo = new ProductRepository();
            Object myObject = new Object();
            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"Product: {myProdRepo.ToString()}");
        }
    }
}
