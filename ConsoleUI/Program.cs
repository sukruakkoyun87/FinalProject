using System;
using System.Linq;
using System.Net.Http.Headers;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetByUnitPirce(15,60))
            {
                Console.WriteLine("Ürün Adi : {0}     -- Fiyat  : {1} ",product.ProductName,product.UnitPrice);
            }

            
        }
    }
}
