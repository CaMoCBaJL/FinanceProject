using FinanceApp.Domain.Abstract.Interfaces;

namespace FinanceApp.Domain.Abstract
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
    }
}
