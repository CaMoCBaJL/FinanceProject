namespace FinanceApp.Domain.Abstract.Repetitions.RepetitionTypes
{
    public class RepetitionPerYear : RepetitionType
    {
        public override int LeftOperationsAmount => throw new NotImplementedException();

        protected override int RepetitionPeriodDaysAmount => throw new NotImplementedException();
    }
}
