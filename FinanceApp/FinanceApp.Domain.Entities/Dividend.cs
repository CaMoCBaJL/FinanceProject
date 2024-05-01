using FinanceApp.Domain.Abstract;

namespace FinanceApp.Domain.Entities
{
    /// <summary>
    /// Дивиденд
    /// </summary>
    public class Dividend: Entity
    {
        public DateTime PaymentDate { get; set; }

        public decimal Percent { get; set; }
        
        public decimal MoneyAmount { get; set; }
    }
}
