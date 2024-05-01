using FinanceApp.Domain.Abstract;

namespace FinanceApp.Domain.Assets.Bonds
{
    public abstract class BondTicket : Entity
    {
        public decimal Cost { get; set; }

        public decimal Percent { get; set; }
    }
}
