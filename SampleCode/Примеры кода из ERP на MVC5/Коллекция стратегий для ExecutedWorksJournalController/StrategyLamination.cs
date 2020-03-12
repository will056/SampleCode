using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleCode.Примеры_кода_из_ERP_на_MVC5.Коллекция_стратегий
{
    /// <summary>
    /// Стратегия участка Ламинация
    /// + Дополнительные методы для работы с листами
    /// </summary>
    public class StrategyLamination : StategyOPZ<LaminationWorksJournal>
    {
        WorkWithSheetExecutedWorkJournal workWithSheet = new WorkWithSheetExecutedWorkJournal();

        public virtual decimal RecalcCountCard(DataCalcProduct data)
        {
            return workWithSheet.RecalcCountCard(data);
        }

        public virtual List<SelectListItem> GroupedListSheetFormat(List<RefSheetFormat> RefSheetFormat)
        {
            return workWithSheet.GroupedListSheetFormat(RefSheetFormat);
        }

        public override object InsertOrUpdate(LaminationWorksJournal value, object id)
        {
            var rep = new RepositoryLaminationWorksJournal();

            return rep.InsertOrUpdate(value, id);
        }

        public override Task DeleteAsync(object id)
        {
            return new RepositoryLaminationWorksJournal().DeleteAsync(id);
        }

        public override Task<LaminationWorksJournal> SelectByIdAsync(object id)
        {
            return new RepositoryLaminationWorksJournal().SelectByIdAsync(id);
        }

        public override Task<ProcessingStatus> ValidationBeforeInsertOrUpdateAsync(LaminationWorksJournal value)
        {
            throw new NotImplementedException();
        }
    }
}
