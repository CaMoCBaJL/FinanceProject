using FinanceApp.Domain.Abstract.Interfaces;

namespace FinanceApp.Domain.Abstract
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
    }

    public abstract class Entity<T>: IValidatable
    {
        public T Value { get; set; }

        public abstract void Validate();
    }
}
