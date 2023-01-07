using ProductAPI.Model;

namespace ProductAPI.Respository
{
    public interface IProductRepository 
    {
        List<Product> GetAllProducts();
        
        bool AddProduct(Product product);
        bool RemoveProduct(Product product);  
    }
}
