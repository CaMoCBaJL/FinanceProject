namespace FinanceApp.Domain.Abstract.Repetitions.RepetitionTypes.RepetitionPerYear
{
    public class RepetitionPerYear : RepetitionType
    {
        [Obsolete(ErrorMessages.ConstructorUsageForbidden, true)]
        public RepetitionPerYear() { }

        protected override uint RepetitionPeriodDaysAmount => 365;
    }
}
