using System;

namespace Ders_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();

            product1.Id = 1;
            product1.Id = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 2, ProductName = "Sandalye", UnitPrice = 100, UnitsInStock = 4 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);


        }
    }
}
