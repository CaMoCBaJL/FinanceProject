using FinanceApp.Domain.Abstract.EntityBase;

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
