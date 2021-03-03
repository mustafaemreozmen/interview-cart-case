namespace Interview.CartCase.Domain.Entities
{
    public class Product: MongoBaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string MeasureType { get; set; }
        public string Barcode { get; set; }
        public string ImageUri { get; set; }
        public ProductType ProductType { get; set; }
        public PriceInfo Price { get; set; }
        public SellerInfo SellerInfo { get; set; }
        public ShipmentInfo ShipmentInfo { get; set; }
    }
}