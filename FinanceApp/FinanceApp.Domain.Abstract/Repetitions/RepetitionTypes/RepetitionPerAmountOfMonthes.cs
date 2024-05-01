namespace FinanceApp.Domain.Abstract.Repetitions.RepetitionTypes
{
    public class RepetitionPerAmountOfMonthes : RepetitionType
    {
        public override int LeftOperationsAmount => throw new NotImplementedException();

        protected override int RepetitionPeriodDaysAmount => throw new NotImplementedException();

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
