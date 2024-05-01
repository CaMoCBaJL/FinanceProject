using FinanceApp.Domain.Abstract;

namespace FinanceApp.Domain.Entities
{
    public class Deposit: Entity
    {
        public decimal Amount { get; set; }

        public decimal AnnualPercent { get; set; }

        public DateTime OpenDate { get; set; }

        public string Name { get; set; }

        public Replenishment[] Replenishments { get; set; }

        public RepetitionType PaymentType { get; set; }

        public Issuer Issuer { get; set; }

        public Currency Currency { get; set; }
    }
}
