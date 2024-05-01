using FinanceApp.Domain.Abstract;

namespace FinanceApp.Domain.Assets.Shares
{
    /// <summary>
    /// Акция
    /// </summary>
    public abstract class Share : TradableEntity
    {
        public string Name { get; set; }

        public Issuer Issuer { get; init; }

        public List<Dividend> Dividends { get; set; }
    }
}
