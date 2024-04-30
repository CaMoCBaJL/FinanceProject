using FinanceApp.Domain.Abstract;

namespace FinanceApp.Domain.Entities
{
    public class Replenishment : Entity
    {
        public decimal Amount { get; set; }

        public RepetitionType Type { get; set; }
    }
}
