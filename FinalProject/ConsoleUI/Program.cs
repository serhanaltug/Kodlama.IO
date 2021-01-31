using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
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
