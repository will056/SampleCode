using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleCode.Примеры_кода_из_ERP_на_MVC5.Коллекция_стратегий
{
    /// <summary>
    /// Коллекции стратегий журнала выполненных работ
    /// </summary>
    /// <typeparam name="T">модель данных</typeparam>
    public class CollectionStrategyWorksJournal<T> where T : class
    {
        IUnitOfWork UnitOfWork;

        public CollectionStrategyWorksJournal(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        /// <summary>
        /// Стратегии IStrategyCore T- модель данных
        /// </summary>
        /// <returns></returns>
        public IStrategyCore<T> GetStategyCore()
        {
            Dictionary<Type, Func<IStrategyCore<T>>> jg = new Dictionary<Type, Func<IStrategyCore<T>>>() {
            {typeof(LaminationWorksJournal), new Func<IStrategyCore<T>>(() => { return (IStrategyCore<T>)new StrategyLamination(); })},
            {typeof(CuttingDownWorksJournal), new Func<IStrategyCore<T>>(() => { return (IStrategyCore<T>)new StrategyCuttingDown(); })},
            {typeof(StampingWorksJournal), new Func<IStrategyCore<T>>(() => { return (IStrategyCore<T>)new StrategyStamping(); })},
            {typeof(PackageBuildingWorksJournal), new Func<IStrategyCore<T>>(() => { return (IStrategyCore<T>)new StrategyPackageBuilding(); })},
            {typeof(OffsetPrintingWorksJournal), new Func<IStrategyCore<T>>(() => { return (IStrategyCore<T>)new StrategyKomori4(); })},
            {typeof(PlextorWorksJournal), new Func<IStrategyCore<T>>(() => { return (IStrategyCore<T>)new StrategyPlextor(); })},
            {typeof(SilkStencilWorksJournal), new Func<IStrategyCore<T>>(() => { return (IStrategyCore<T>)new SilkStencilStrategy(); })},
            {typeof(IndigoWorkJournal), new Func<IStrategyCore<T>>(() => { return (IStrategyCore<T>)new StrategyIndigo(); })},
            {typeof(ImplantationWorksJournal), new Func<IStrategyCore<T>>(() => { return (IStrategyCore<T>)new StrategyImplantation(); })},
            {typeof(AtlanticWorksJournal), new Func<IStrategyCore<T>>(() => { return (IStrategyCore<T>)new StrategyAtrantic(); })},
            {typeof(EmbossersWorksJournal), new Func<IStrategyCore<T>>(() => { return (IStrategyCore<T>)new StrategyEmbossers(); })},
            {typeof(ManualCodingWorksJournal), new Func<IStrategyCore<T>>(() => { return (IStrategyCore<T>)new StrategyManualCoding(); })},
            {typeof(CassiloWorksJournal), new Func<IStrategyCore<T>>(() => { return (IStrategyCore<T>)new StrategyCassilo(); })},
            {typeof(OKKPackLoyaltyKitsWorksJournal), new Func<IStrategyCore<T>>(() => { return (IStrategyCore<T>)new StrategyPackLoyaltyKits(); })},
            {typeof(OKKWorksJournal), new Func<IStrategyCore<T>>(() => { return (IStrategyCore<T>)new StrategyOKK(); })},
            {typeof(InterruptionDefectiveWJ), new Func<IStrategyCore<T>>(() => { return (IStrategyCore<T>)new StrategyInterruptionDefective(); })},
            {typeof(MailOkWorksJournal), new Func<IStrategyCore<T>>(() => { return (IStrategyCore<T>)new StrategyMailOk(); })},
            {typeof(MGIWorksJournal), new Func<IStrategyCore<T>>(() => { return (IStrategyCore<T>)new StrategyMGI(); })},
            {typeof(KirkRudyWorksJournal), new Func<IStrategyCore<T>>(() => { return (IStrategyCore<T>)new StrategyKirkRudy(); })},
            {typeof(PrepressWorksJournal), new Func<IStrategyCore<T>>(() => { return (IStrategyCore<T>)new StrategyPrepressCuttingDown(); })},
            {typeof(OPIWorkJournal), new Func<IStrategyCore<T>>(() => { return (IStrategyCore<T>)UnitOfWork.RepositoryOPIWorksJournal; })}


        };

            Func<IStrategyCore<T>> strategy = null;

            if (jg.TryGetValue(typeof(T), out strategy))
                return strategy();
            else
                throw new ArgumentException("Не найдена стратегия для журнала выполненных работ");
        }
    }
}
