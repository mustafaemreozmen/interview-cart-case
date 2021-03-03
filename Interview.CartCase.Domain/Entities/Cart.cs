using System.Collections.Generic;

namespace Interview.CartCase.Domain.Entities
{
    public class Cart: MongoBaseEntity
    {
        public Customer Customer { get; set; }
        public IEnumerable<CartItem> CartItems { get; set; } 
    }
}