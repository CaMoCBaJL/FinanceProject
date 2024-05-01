using FinanceApp.Domain.Abstract;

namespace FinanceApp.Domain.Entities
{
    /// <summary>
    /// Акция
    /// </summary>
    public class Share: Entity
    {
        public string Name { get; set; }

        public Issuer Issuer { get; init; }

        public List<Dividend> Dividends { get; set; }
    }
}
