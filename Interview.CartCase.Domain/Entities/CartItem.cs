namespace Interview.CartCase.Domain.Entities
{
    public class CartItem: MongoBaseEntity
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}