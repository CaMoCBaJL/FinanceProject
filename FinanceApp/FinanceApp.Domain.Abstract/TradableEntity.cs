namespace FinanceApp.Domain.Abstract
{
    public class TradableEntity: CashFlow
    {
        public required DateTime BuyDate { get; set; }

        // DOM (Depth of market https://www.banki.ru/news/daytheme/?id=10972293) min value
        public decimal DOMMinimalCost { get; set; }

        // DOM (Depth of market https://www.banki.ru/news/daytheme/?id=10972293) max value
        public decimal CurrentMaxCost { get; set; }

        public Issuer Issuer { get; init; }
    }
}
