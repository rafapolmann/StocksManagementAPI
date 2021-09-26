namespace StocksManagement.Domain.Features.StockModule
{
    public class Stock
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal CurrentValue { get; set; }
    }
}
