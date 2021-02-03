using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class ProductDal : IProductDal
    {
        List<Product> _products;

        public ProductDal()
        {
            _products = new List<Product>
            {
                new Product{ ProductId = 1, CategoryId = 1, ProductName = "Bardak", UnitPrice = 15, UnitsInStock = 15},
                new Product{ ProductId = 2, CategoryId = 1, ProductName = "Fincan", UnitPrice = 5, UnitsInStock = 20},
                new Product{ ProductId = 3, CategoryId = 2, ProductName = "Telefon", UnitPrice = 500, UnitsInStock = 2},
                new Product{ ProductId = 4, CategoryId = 2, ProductName = "Klavye", UnitPrice = 50, UnitsInStock = 5},
                new Product{ ProductId = 5, CategoryId = 2, ProductName = "Fare", UnitPrice = 10, UnitsInStock = 1},
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            var productToDelete = _products.SingleOrDefault(x => x.ProductId == product.ProductId);
            if(productToDelete != null) _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(x => x.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            var productToUpdate = _products.SingleOrDefault(x => x.ProductId == product.ProductId);
            if (productToUpdate != null) { 
                productToUpdate.ProductName = product.ProductName;
                productToUpdate.CategoryId = product.CategoryId;
                productToUpdate.UnitPrice = product.UnitPrice;
                productToUpdate.UnitsInStock = product.UnitsInStock;
            }
        }
    }
}
