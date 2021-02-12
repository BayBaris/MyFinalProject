using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //NuGet...
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetailDto> GetProcudtDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                //Ling kullanarak join atma...
                var result = from p in context.Products //Ürünlerden...
                             join c in context.Categories // Kategorilere gir...
                             on p.CategoryID equals c.CategoryID // İkisinde de bulunan ID'leri eşitle...
                             select new ProductDetailDto //Bu nesneyi newleyerek seç..
                             {
                                 // içerisine yazılacak nesnelerin karşılığını tablodaki değerlerden ata...
                                 ProductID = p.ProductID,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName,
                                 UnitsInStock = p.UnitsInStock
                             };
                return result.ToList();
            }
        }
    }
}
