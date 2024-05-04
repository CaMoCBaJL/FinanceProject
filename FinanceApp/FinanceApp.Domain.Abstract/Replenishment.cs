using FinanceApp.Domain.Abstract.EntityBase;
using FinanceApp.Domain.Abstract.Repetitions;

namespace FinanceApp.Domain.Abstract
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
