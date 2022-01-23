namespace FastMeal.Commom.Domain.Info
{
    public record Address
    {
        public string City { get; set; }

        public string State { get; set; }

        public string? ZipCode { get; set; }

        public string Street { get; set; }
    }
}
