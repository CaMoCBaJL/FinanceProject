using FinanceApp.Domain.Abstract;

namespace FinanceApp.Domain.Liabilities.Debts
{
    /// <summary>
    /// Кредит(долг / ссуда)
    /// </summary>
    public class Debt : Entity
    {
        public decimal Amount { get; set; }

        public decimal Percent { get; set; }

        public DateTime StartDate { get; set; }

        public string Name { get; set; }

        public DateTime EndDate { get; set; }

        public Replenishment[] Repaiments { get; set; }

        public Currency Currency { get; set; }
    }
}
