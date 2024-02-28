using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>()
            {
                new Product() { ProductId = 1, CategoryId = 1, ProductName = "Klavye", UnitPrice = 420, UnitsInStock = 0 },
                new Product() { ProductId = 1, CategoryId = 2, ProductName = "Tesbih", UnitPrice = 420, UnitsInStock = 0 },
                new Product() { ProductId = 1, CategoryId = 3, ProductName = "Top", UnitPrice = 420, UnitsInStock = 0 },
                new Product() { ProductId = 1, CategoryId = 1, ProductName = "Çay", UnitPrice = 420, UnitsInStock = 0 }
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            var deletedProduct = _products.FirstOrDefault(x=>x.ProductId==product.ProductId);
            _products.Remove(deletedProduct);
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
            return _products.Where(p=>p.CategoryId==categoryId).ToList();
        }

        public void Update(Product product)
        {
            var updatedProduct = _products.FirstOrDefault(x => x.ProductId == product.ProductId);
            updatedProduct.ProductName = product.ProductName;
            updatedProduct.UnitPrice = product.UnitPrice;
            updatedProduct.CategoryId = product.CategoryId;
            updatedProduct.UnitsInStock = product.UnitsInStock;
        }
    }
}
       


       
