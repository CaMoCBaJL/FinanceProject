namespace FinanceApp.Domain.Abstract.Repetitions.RepetitionTypes
{
    public class RepetitionPerAmountOfMonths : RepetitionType
    {
        private RepetitionPerAmountOfMonths(Duration Duration) : base(Duration)
        {
        }

        public override int LeftOperationsAmount => throw new NotImplementedException();

        protected override int RepetitionPeriodDaysAmount => throw new NotImplementedException();

        public static RepetitionPerAmountOfMonths Create(Duration duration)
        {
            throw new NotImplementedException();

            return new RepetitionPerAmountOfMonths(duration);
        }
    }
}
