namespace FinanceApp.Domain.Abstract.Repetitions.RepetitionTypes.NoRepetition
{
    public class NoRepetition : RepetitionType
    {
        [Obsolete(ErrorMessages.ConstructorUsageForbidden, true)]
        public NoRepetition() { }

        public override uint DaysUntilNextOperation => 0;

        public override uint LeftOperationsAmount => 1;

        protected override uint RepetitionPeriodDaysAmount => 0;
    }
}
