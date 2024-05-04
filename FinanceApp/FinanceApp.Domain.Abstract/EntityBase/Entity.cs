namespace FinanceApp.Domain.Abstract.EntityBase
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
    }

    public abstract class Entity<T> : Entity
    {
        public Entity() { }

        public T Value { get; set; }
    }
}
