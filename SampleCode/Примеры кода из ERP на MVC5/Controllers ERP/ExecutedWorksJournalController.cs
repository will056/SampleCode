using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleCode.Controllers_ERP
{
    [Authorize]

    public class ExecutedWorksJournalController : Controller
    {
        IUnitOfWork UnitOfWork;

        //DI
        public ExecutedWorksJournalController(IUnitOfWork UnitOfWork)
        {
            this.UnitOfWork = UnitOfWork;
        }

        [RoleAccess(Roles = "admin,chief_implantation_umj,senior_implantation_umj")]
        public async System.Threading.Tasks.Task<JsonResult> DeleteImplantation(int id)
        {
            return await DeleteAsync<ImplantationWorksJournal>(id);
        }

        //Полиморфный объект общий для всех журналов выполненных работ. 
        //По тиму модели базы вызывается необходимая стратегия

        /// <summary>
        /// Удалить запись журнала 
        /// </summary>
        private async System.Threading.Tasks.Task<JsonResult> DeleteAsync<ModelDb>(int id) where ModelDb : class
        {
            #region Проверка существования записи в соответствующем журнале 
            // CollectionStrategyWorksJournal Коллекция стратегий в одтельном файле - CollectionStrategyWorksJournal
            var strategy = new CollectionStrategyWorksJournal<ModelDb>(UnitOfWork)
                    .GetStategyCore();

            if ((await strategy.SelectByIdAsync(id)) == null)
            {
                LogProxy.Log(new DataLog(level: LogLevel.Warn, message: "Ошибка при удалении. Не удалось найти запись", id: id.ToString(), context: ContexLog.ExecutedWorkJournal));
                return Json(ConstMessage.DeleteUnexpectedError, JsonRequestBehavior.AllowGet);
            }

            #endregion

            try
            {
                var repExecutedWorksJournal = new ContextRepository<ExecutedWorkJournal>(UnitOfWork.RepositoryExecutedWorkJournal);

                var journal = await UnitOfWork.RepositoryExecutedWorksJournal.SelectByIdAsync(id);

                var machine = await UnitOfWork.RepositoryRefMachine.SelectByIdAsync(journal.FkMachine);

                var workArea = await UnitOfWork.RepositoryRefWorkArea.SelectByIdAsync(machine.WorkArea);

                //Пометим как удаленную
                journal.IsDeleted = OracleBoolCharExtentions.ToString(true);
                repExecutedWorksJournal.Update(journal);

                LogProxy.Log(new DataLog(level: LogLevel.Info, message: "Удалено. Участок - " + workArea.Name + ", станок " + machine.Name, id: id.ToString(), jsonData: journal, context: ContexLog.ExecutedWorkJournal));

                return Json(ConstMessage.DeleteSuccess, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                LogProxy.Log(new DataLog(level: LogLevel.Error, message: "Ошибка при удалении записи журнала выполненных работ", id: id.ToString(), context: ContexLog.ExecutedWorkJournal, e: e));

                return Json(ConstMessage.DeleteUnexpectedError, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
