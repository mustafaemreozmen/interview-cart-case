namespace Interview.CartCase.Domain.Entities
{
    public class ShipmentInfo: MongoBaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string TrackingKey { get; set; }
        public string Phone { get; set; }
    }
}