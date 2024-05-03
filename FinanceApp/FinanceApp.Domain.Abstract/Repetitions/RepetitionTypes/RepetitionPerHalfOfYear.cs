namespace FinanceApp.Domain.Abstract.Repetitions.RepetitionTypes
{
    public class RepetitionPerHalfOfYear : RepetitionType
    {
        public override int LeftOperationsAmount
        {
            get
            {
                return (int)Value.EndDate.Subtract(RepetitionPeriodStartDate).TotalDays / RepetitionPeriodDaysAmount;
            }
        }

        protected override int RepetitionPeriodDaysAmount => 182;
    }
}
