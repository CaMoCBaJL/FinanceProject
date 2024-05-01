using FinanceApp.Domain.Abstract;

namespace FinanceApp.Domain.Entities
{
    public abstract class BondTicket: Entity
    {
        public decimal Cost { get; set; }

        public decimal Percent { get; set; }
    }
}
