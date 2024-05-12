namespace Shared
{
    public class Currency
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal ExchangeRateUSD { get; set; }
    }
}