using FinanceApp.Domain.Abstract;

namespace FinanceApp.Domain.Assets.Shares
{
    /// <summary>
    /// Дивиденд
    /// </summary>
    public class Dividend : Entity
    {
        public DateTime PaymentDate { get; set; }

        public decimal Percent { get; set; }

        public decimal MoneyAmount { get; set; }
    }
}
