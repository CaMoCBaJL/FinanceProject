namespace FinanceApp.Domain.Abstract.Repetitions.RepetitionTypes.NoRepetition
{
    public class NoRepetition : RepetitionType
    {
        [Obsolete("Нельзя создавать данный объект напрямую. Воспользуйтесь соответсвующей фабрикой", true)]
        public NoRepetition() { }

        public override int DaysUntilNextOperation => 0;

        public override int LeftOperationsAmount => 1;

        protected override int RepetitionPeriodDaysAmount => 0;
    }
}
