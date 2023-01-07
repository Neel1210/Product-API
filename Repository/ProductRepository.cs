using ProductAPI.Model;
using System.Collections.Generic;
using System.Xml.Linq;

namespace ProductAPI.Respository;

public class ProductRepository : IProductRepository
{
    List<Product> products = new List<Product>() { new Product() { Id = 1, Name = "Product1", Price = 11000 }, new Product() { Id = 2, Name = "Product2", Price = 21000 }, new Product() { Id = 3, Name = "Product3", Price = 31000 }};

    public ProductRepository()
    {

    }


    public bool AddProduct(Product product)
    {
        products.Add(product);
        return true;
    }

    public bool RemoveProduct(Product product)
    {
        return true==products.Remove(product);
    }

    public List<Product> GetAllProducts()
    {
        return products;
    }
}
