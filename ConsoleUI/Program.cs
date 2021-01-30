using System;
using System.Linq;
using System.Net.Http.Headers;
using Business.Concrete;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine("Ürün Adi : {0}  ",product.ProductName);
            }
            
        }
    }
}
