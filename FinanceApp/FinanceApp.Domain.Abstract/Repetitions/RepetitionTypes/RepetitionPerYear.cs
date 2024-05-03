using FinanceApp.Domain.Exceptions;

namespace FinanceApp.Domain.Abstract.Repetitions.RepetitionTypes
{
    public class RepetitionPerYear : RepetitionType
    {
        public override int LeftOperationsAmount => throw new NotImplementedException();

        protected override int RepetitionPeriodDaysAmount => throw new NotImplementedException();
    }

    public class ValueParser<TData, TEntityForValue>
        where TEntityForValue: Entity<TData>
    {
        public virtual TData Parse(TData sourceData)
        {
            return sourceData;
        }
    }

    public abstract class ValueValidator<TData, TEntityToValidate>
        where TEntityToValidate: Entity<TData>
    {
        public abstract void Validate(TData data);
    }

    public abstract class EntityFactory<TValueType, TResultType, TValidatorType, TParserType>
        where TResultType : Entity<TValueType>, new()
        where TValidatorType : ValueValidator<TValueType, TResultType>, new()
        where TParserType: ValueParser<TValueType, TResultType>, new()
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

    public class NoRepetitionValidator : ValueValidator<Duration, NoRepetition>
    {
        public override void Validate(Duration duration)
        {
            if (duration.StartDate != duration.EndDate)
            {
                throw new RepetitionPeriodIncorrectException();
            }
        }
    }

    //the last one question: how prevent entity creation using constructor
    public class NoRepetitionFactory : EntityFactory<Duration, NoRepetition, NoRepetitionValidator, ValueParser<Duration, NoRepetition>>
    {
       public NoRepetitionFactory() { }
    }
}
