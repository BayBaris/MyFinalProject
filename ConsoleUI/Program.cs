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
            //DTO : Data Transformation Object...
            //IoC ile newleme derdimizi çözücez...
            //IoC : 
            ProductTest();
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            Console.WriteLine("Category = 2");
            Console.WriteLine("======================================");
            foreach (var product in productManager.GetAllByCategoryID(2))
            {
                Console.WriteLine(product.ProductName);
            }
            Console.WriteLine("======================================");
            Console.WriteLine("----Product And Category Name-----");
            Console.WriteLine("======================================");
            foreach (var product in productManager.GetProcudtDetails())
            {
                Console.WriteLine(product.ProductName + "/" + product.CategoryName);
            }
            Console.WriteLine("======================================");
        }
    }
}
