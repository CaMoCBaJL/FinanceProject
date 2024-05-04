namespace FinanceApp.Domain.Abstract
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
