using FinanceApp.Domain.Abstract;
using FinanceApp.Domain.Abstract.Repetitions;
using FinanceApp.Domain.Abstract.Repetitions.RepetitionTypes;

namespace FinanceApp.Domain.Assets.Bonds
{
    /// <summary>
    /// Облигация
    /// </summary>
    public abstract class Bond : TradableEntity
    {
        public string Name { get; set; }

        /// <summary>
        /// Период выплаты купонов
        /// </summary>
        public RepetitionType PaymentType { get; init; }

        /// <summary>
        /// Период обращения
        /// </summary>
        public Duration CirculationPeriod { get; set; }

        /// <summary>
        /// Среднее время в днях, за которое вкладчик полностью вернёт свои вложения в облигацию
        /// </summary>
        public virtual int Duration
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// YTM(Yield To Maturity) - Доходность к погашению (https://www.alt-invest.ru/lib/ytm/)
        /// </summary>
        public decimal YTM
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Текущая доходность
        /// </summary>
        public decimal CurrentProfitability
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Будущая доходность
        /// </summary>
        public decimal FutureProfitability
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Купон по облигации
        /// </summary>
        public BondTicket Ticket { get; set; }
    }
}