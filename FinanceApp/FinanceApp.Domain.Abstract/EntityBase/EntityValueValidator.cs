using FinanceApp.Domain.Abstract.EntityBase;

namespace FinanceApp.Domain.Abstract.EntityBase
{
    public abstract class ValueValidator<TData, TEntityToValidate>
            where TEntityToValidate : Entity<TData>
    {
        public abstract void Validate(TData data);
    }
}
