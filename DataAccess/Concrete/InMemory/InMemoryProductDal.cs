using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        //naming convencion
        List<Product> _products;
        // ProductDal çalıştığında Products
        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product
                {
                    ProductID = 1,CategoryID = 1,ProductName = "Bardak",UnitPrice = 15,UnitsInStock = 15
                },
                new Product
                {
                    ProductID = 2,CategoryID = 1,ProductName = "Kamera",UnitPrice = 500,UnitsInStock = 3
                },
                new Product
                {
                    ProductID = 3,CategoryID = 2,ProductName = "Telefon",UnitPrice = 1500,UnitsInStock = 2
                },
                new Product
                {
                    ProductID = 4,CategoryID = 2,ProductName = "Klavye",UnitPrice = 150,UnitsInStock = 65
                },
                new Product
                {
                    ProductID = 5,CategoryID = 2,ProductName = "Fare",UnitPrice = 85,UnitsInStock = 1
                }
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            // LINQ --> Language Integrated Query...
            // LINQ olmadan...
            //Product productToDelete = null; //newlemek gereksiz,sadece referans numarası atıyoruz...
            //foreach (var p in _products)
            //{
            //    if (product.ProductID == p.ProductID)
            //    {
            //        productToDelete = p;
            //    }
            //}
            //Her p için p'nin product ID'sinin bizim yolladığımız product'ın 
            //Product ID'sine eşit olup olmadığına bak...
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductID == product.ProductID);//Lambda =>
            _products.Remove(productToDelete);
            

        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            //Tüm listeyi döndürür...
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryID)
        {
            //Products'da bulunan categoryIDlerini bir liste haline getirip onu döndürür...
            return _products.Where(p => p.CategoryID == categoryID).ToList();
        }

        public void Update(Product product)
        {
            //Gönderilen ürünün Id'sine sahip olan listedeki ürünü bulur.
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductID == product.ProductID);//Lambda =>
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryID = product.CategoryID;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
