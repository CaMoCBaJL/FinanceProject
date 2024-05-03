namespace FinanceApp.Domain.Validation
{
    public abstract class EntityValidator<T>
    {
        public abstract void Validate(T entity);
    }
}
