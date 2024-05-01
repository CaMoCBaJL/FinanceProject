using FinanceApp.Domain.Abstract;

namespace FinanceApp.Domain.Entities
{
    /// <summary>
    /// Пополнение счета (в случае с долговыми инструментами - досрочный платеж)
    /// </summary>
    public class Replenishment : Entity
    {
        public decimal Amount { get; set; }

        public RepetitionType Type { get; set; }
    }
}
