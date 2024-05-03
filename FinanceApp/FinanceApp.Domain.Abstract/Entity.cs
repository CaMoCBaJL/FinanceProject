namespace FinanceApp.Domain.Abstract
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
    }

    public abstract class Entity<T> : Entity
    {
        public T Value { get; set; }
    }
}
