namespace Interview.CartCase.Domain.Entities
{
    public class ProductType: MongoBaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}