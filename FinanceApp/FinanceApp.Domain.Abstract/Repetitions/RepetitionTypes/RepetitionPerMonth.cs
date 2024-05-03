namespace FinanceApp.Domain.Abstract.Repetitions.RepetitionTypes
{
    public class RepetitionPerMonth : RepetitionType
    {
        private RepetitionPerMonth(Duration duration) : base(duration)
        {
        }

        public override int LeftOperationsAmount => throw new NotImplementedException();

        protected override int RepetitionPeriodDaysAmount => throw new NotImplementedException();

        public static RepetitionPerMonth Create(Duration duration)
        {
            throw new NotImplementedException();

            return new RepetitionPerMonth(duration);
        }
    }
}
