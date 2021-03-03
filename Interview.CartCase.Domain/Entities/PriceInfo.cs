using System;
namespace Interview.CartCase.Domain.Entities
{
    public class PriceInfo: MongoBaseEntity
    {
        public Decimal Price { get; set; }
    }
}