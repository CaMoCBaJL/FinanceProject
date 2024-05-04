using FinanceApp.Domain.Abstract.EntityBase;
using FinanceApp.Domain.Exceptions;

namespace FinanceApp.Domain.Abstract.Repetitions
{
    public class RepetitionTypeValidator<TRepetitionType> : ValueValidator<Duration, TRepetitionType>
        where TRepetitionType : RepetitionType
    {
        public override void Validate(Duration duration)
        {
            if (duration.StartDate >= duration.EndDate)
            {
                throw new RepetitionPeriodIncorrectException();
            }
        }
    }
}
