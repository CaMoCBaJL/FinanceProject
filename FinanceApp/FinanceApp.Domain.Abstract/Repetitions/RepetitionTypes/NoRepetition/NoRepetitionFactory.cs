using FinanceApp.Domain.Abstract.EntityBase;

namespace FinanceApp.Domain.Abstract.Repetitions.RepetitionTypes.NoRepetition
{
    public class NoRepetitionFactory : EntityFactory<Duration, NoRepetition, NoRepetitionValidator, ValueParser<Duration, NoRepetition>>
    {
    }
}
