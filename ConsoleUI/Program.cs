using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            Console.WriteLine("Category = 2");
            Console.WriteLine("============================");
            foreach (var product in productManager.GetAllByCategoryID(2))
            {
                Console.WriteLine(product.ProductName);
            }
            Console.WriteLine("============================");
            Console.WriteLine("Unit Price between 20 - 200");
            Console.WriteLine("============================");
            foreach (var product in productManager.GetByUnitPrice(20,200))
            {
                Console.WriteLine(product.ProductName);
            }
            Console.WriteLine("============================");

        }
    }
}
