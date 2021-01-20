using System;

namespace Ders_4_1
{
    class ProductManager
    {
        public void Add(Product product) 
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        public void Delete(Product product)
        {
            Console.WriteLine(product.ProductName + " silindi.");
        }
    }
}
