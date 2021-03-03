namespace Interview.CartCase.Domain.Entities
{
    public class Address: MongoBaseEntity
    {
        public string LineOne { get; set; }
        public string LineTwo { get; set; }
        public string LineThree { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }


    }
}