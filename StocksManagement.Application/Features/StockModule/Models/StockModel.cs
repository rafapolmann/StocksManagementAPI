namespace StocksManagement.Application.Features.StockModule.Models
{
    public class StockModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal CurrentValue { get; set; }
    }
}
