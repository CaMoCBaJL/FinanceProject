using FinanceApp.Domain.Exceptions;

namespace FinanceApp.Domain.Abstract.RepetitionTypes
{
    public class NoRepetition : RepetitionType
    {
        public override int DaysUntilNextOperation => 0;

        public override int LeftOperationsAmount => 1;

        protected override int RepetitionPeriodDaysAmount => 0;

        public override void Validate()
        {
            if (Duration.StartDate != Duration.EndDate)
            {
                throw new RepetitionPeriodIncorrectException();
            }
        }
    }
}
