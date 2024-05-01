using FinanceApp.Domain.Abstract;

namespace FinanceApp.Domain.Entities
{
    public class Dividend: Entity
    {
        public DateTime PaymentDate { get; set; }

        public decimal Percent { get; set; }
        
        public decimal MoneyAmount { get; set; }
    }
}
