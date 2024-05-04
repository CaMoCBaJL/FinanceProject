namespace FinanceApp.Domain.Abstract
{
    public abstract class EntityFactory<TValueType, TResultType, TValidatorType, TParserType>
           where TResultType : Entity<TValueType>, new()
           where TValidatorType : ValueValidator<TValueType, TResultType>, new()
           where TParserType : ValueParser<TValueType, TResultType>, new()
    {
        //entity creation life cycle
        public TResultType Create(TValueType value)
        {
            ValidateValue(value);

            var parsedValue = ParseValue(value);

            return CreateEntity(parsedValue);
        }

        protected virtual void ValidateValue(TValueType value)
        {
            new TValidatorType().Validate(value);
        }

        protected virtual TValueType ParseValue(TValueType value)
        {
            return new TParserType().Parse(value);
        }

        protected virtual TResultType CreateEntity(TValueType value)
        {
            var result = new TResultType();
            result.Value = value;

            return result;
        }
    }
}
