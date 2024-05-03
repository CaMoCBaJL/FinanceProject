namespace FinanceApp.Domain.Abstract.Repetitions.RepetitionTypes
{
    public class RepetitionPerHalfOfYear : RepetitionType
    {
        private RepetitionPerHalfOfYear(Duration duration): base(duration) 
        {

        }

        public override int LeftOperationsAmount
        {
            get
            {
                return (int)_duration.EndDate.Subtract(RepetitionPeriodStartDate).TotalDays / RepetitionPeriodDaysAmount;
            }
        }

        public static RepetitionPerHalfOfYear Create(Duration duration)
        {
            throw new NotImplementedException();
            //if (Duration.EndDate.Subtract(Duration.StartDate).TotalDays <)
            //{

            //}

            return new RepetitionPerHalfOfYear(duration);
        }

        protected override int RepetitionPeriodDaysAmount => 182;
    }
}
