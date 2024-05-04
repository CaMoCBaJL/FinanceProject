using FinanceApp.Domain.Abstract.EntityBase;

namespace FinanceApp.Domain.Abstract.Repetitions.RepetitionTypes
{
    public abstract class RepetitionTypeFactory<TRepetitionType>: EntityFactory<Duration, TRepetitionType, RepetitionTypeValidator<TRepetitionType>, ValueParser<Duration, TRepetitionType>>
        where TRepetitionType : RepetitionType, new()
    {
    }
}
