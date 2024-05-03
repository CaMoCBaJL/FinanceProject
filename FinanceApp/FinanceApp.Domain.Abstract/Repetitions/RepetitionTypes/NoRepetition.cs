using FinanceApp.Domain.Exceptions;

namespace FinanceApp.Domain.Abstract.Repetitions.RepetitionTypes
{
    public class NoRepetition: RepetitionType
    {
        private NoRepetition(Duration Duration) : base(Duration)
        {
        }

        public override int DaysUntilNextOperation => 0;

        public override int LeftOperationsAmount => 1;

        protected override int RepetitionPeriodDaysAmount => 0;

        public static NoRepetition Create(Duration Duration)
        {
            if (Duration.StartDate != Duration.EndDate)
            {
                throw new RepetitionPeriodIncorrectException();
            }

            return new NoRepetition(Duration);
        }
    }
}
