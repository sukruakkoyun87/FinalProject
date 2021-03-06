﻿using System;
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
            // ProductTest();

            CategoryTest();

           
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine("Categori Adı : {0}", category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));

            var result = productManager.GetProductDetails();

            if (result.Success)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine("Ürün Adi : {0}     --   Kategori Adi  :  {1} ", product.ProductName, product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
           
        }
    }
}
