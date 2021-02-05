using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetAllByUnitPrice(50,100))
            {
                Console.WriteLine(product.ProductName);
            }
            EfProductDal efProductDal = new EfProductDal();
            efProductDal.Add(new Product { CategoryId = 5, ProductId = 21312, ProductName = "asda", UnitPrice = 21312, UnitsInStock = 2132 });
        }
    }
}
