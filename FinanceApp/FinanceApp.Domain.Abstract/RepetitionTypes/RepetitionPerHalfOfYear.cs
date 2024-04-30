namespace FinanceApp.Domain.Abstract.RepetitionTypes
{
    public class RepetitionPerHalfOfYear : RepetitionType
    {
        public override int LeftOperationsAmount
        {
            get
            {
                return (int)Duration.EndDate.Subtract(RepetitionPeriodStartDate).TotalDays / RepetitionPeriodDaysAmount;
            }
        }

        public override void Validate()
        {
            if (Duration.EndDate.Subtract(Duration.StartDate).TotalDays <) 
            {
                
            }
        }

        protected override int RepetitionPeriodDaysAmount => 182;
    }
}
