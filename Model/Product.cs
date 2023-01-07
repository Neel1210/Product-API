namespace ProductAPI.Model
{
    public class Product : Object
    {
        
        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public override bool Equals(Object obj)
        {
            Product product = (Product)obj;
            if (this.Id == product.Id && this.Name == product.Name && this.Price == product.Price)
                return true;
            return false;
        }
    }
}
