namespace Interview.CartCase.Domain.Entities
{
    public class SellerInfo: MongoBaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Address Address { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
    }
}