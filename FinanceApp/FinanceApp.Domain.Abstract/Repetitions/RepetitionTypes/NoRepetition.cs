using FinanceApp.Domain.Exceptions;

namespace FinanceApp.Domain.Abstract.Repetitions.RepetitionTypes
{
    public class NoRepetition: RepetitionType
    {
        public override int DaysUntilNextOperation => 0;

        public override int LeftOperationsAmount => 1;

        protected override int RepetitionPeriodDaysAmount => 0;
    }
}
