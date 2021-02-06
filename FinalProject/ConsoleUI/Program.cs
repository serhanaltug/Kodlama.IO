using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            //CategoryTest();

            ProductManager productManager = new ProductManager(new ProductDal());

            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName + " - " + product.CategoryName);
            }

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new CategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new ProductDal());
            List<Product> products = productManager.GetAll();
            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
