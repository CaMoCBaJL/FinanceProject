using FinanceApp.Domain.Abstract.EntityBase;

namespace FinanceApp.Domain.Assets.Bonds
{
    public abstract class BondTicket : Entity
    {
        public decimal Cost { get; set; }

        public decimal Percent { get; set; }
    }
}
