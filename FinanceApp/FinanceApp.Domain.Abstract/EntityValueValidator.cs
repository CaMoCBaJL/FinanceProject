namespace FinanceApp.Domain.Abstract
{
    public abstract class ValueValidator<TData, TEntityToValidate>
            where TEntityToValidate : Entity<TData>
    {
        public abstract void Validate(TData data);
    }
}
