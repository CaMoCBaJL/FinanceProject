namespace FinanceApp.Domain.Abstract.Repetitions.RepetitionTypes.RepetitionPerHalfOfYear
{
    public class RepetitionPerHalfOfYear : RepetitionType
    {
        [Obsolete(ErrorMessages.ConstructorUsageForbidden, true)]
        public RepetitionPerHalfOfYear() { }

        protected override uint RepetitionPeriodDaysAmount => 182;
    }
}
