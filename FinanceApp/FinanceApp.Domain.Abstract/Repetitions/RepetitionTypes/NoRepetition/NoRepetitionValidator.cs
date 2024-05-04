using FinanceApp.Domain.Exceptions;

namespace FinanceApp.Domain.Abstract.Repetitions.RepetitionTypes.NoRepetition
{
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
}
