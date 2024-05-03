namespace FinanceApp.Domain.Abstract.Repetitions.RepetitionTypes
{
    public class RepetitionPerQuarter : RepetitionType
    {
        private RepetitionPerQuarter(Duration duration) : base(duration)
        {
        }

        public override int LeftOperationsAmount => throw new NotImplementedException();

        protected override int RepetitionPeriodDaysAmount => throw new NotImplementedException();

        public static RepetitionPerQuarter Create(Duration duration)
        {
            throw new NotImplementedException();

            return new RepetitionPerQuarter(duration);
        }
    }
}
