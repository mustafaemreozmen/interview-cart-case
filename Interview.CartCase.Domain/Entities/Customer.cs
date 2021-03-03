namespace Interview.CartCase.Domain.Entities
{
    public class Customer: MongoBaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Description { get; set; }
        public string PhotoUri { get; set; }
        public Address Address { get; set; }
        
        
    }
}