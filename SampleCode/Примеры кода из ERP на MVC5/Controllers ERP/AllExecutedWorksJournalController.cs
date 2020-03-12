using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleCode.Примеры_кода_из_ERP_на_MVC5.Controllers_ERP
{
    /// <summary>
    /// Все записи выполненный работ
    /// </summary>
    [Authorize]
    public class AllExecutedWorksJournalController : Controller
    {
        [ClioAuthorization(Roles = new string[] { ConstRole.Admin, ConstRole.Chief, ConstRole.ChiefManualCoding, ConstRole.SeniorManualCoding, ConstRole.UserManualCoding, ConstRole.ChiefAuditor, ConstRole.Auditor, ConstRole.Viewer })]
        public async Task<JsonResult> ServerSideSearchManualCoding(DataTableAjaxPostModel model, bool amongDeleted = false)
        {
            try
            {
                //Удалить все пробелы перед и после поисковых значений
                model.columns = SingletonUtil.Instance.TrimValue(model.columns);

                var contex = new ContextAll<AllManualCoding>(new StrategyAllManualCoding(model, amongDeleted, User.Identity.Name));

                var recordsTotal = contex.SelectAllCountAsync();

                var resultSelect = contex.SelectAjaxAsync();

                var recordsFiltered = contex.SelectCountAsync();

                await Task.WhenAll(recordsTotal, resultSelect, recordsFiltered);

                List<AllManualCoding_VM> vm = new AllManualCoding_VM().Convert(resultSelect.Result.ToList());

                return Json(new
                {
                    // this is what datatables wants sending back
                    draw = model.draw,
                    recordsTotal = recordsTotal.Result,
                    recordsFiltered = recordsFiltered.Result,
                    data = vm
                });
            }
            catch (Exception e)
            {
                LogProxy.Log(new DataLog(level: LogLevel.Error, message: "Ошибка поиске данных журнала ручного кодирования", jsonData: model, id: "", context: ContexLog.ExecutedWorkJournal, e: e));
                return Json(null);
            }
        }
    }
}
