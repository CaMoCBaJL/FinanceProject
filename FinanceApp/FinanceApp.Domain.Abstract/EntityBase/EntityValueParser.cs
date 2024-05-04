using FinanceApp.Domain.Abstract.EntityBase;

namespace FinanceApp.Domain.Abstract.EntityBase
{
    public class ValueParser<TData, TEntityForValue>
            where TEntityForValue : Entity<TData>
    {
        public virtual TData Parse(TData sourceData)
        {
            return sourceData;
        }
    }
}
