using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleCode.Примеры_кода_из_ERP_на_MVC5.Коллекция_стратегий
{
    /// <summary>
    /// Стратегия для выполненных работ участка печати
    /// </summary>
    abstract public class StategyOPZ<T> : IStrategyCore<T>
    {
        public abstract Task DeleteAsync(object id);
        public abstract object InsertOrUpdate(T value, object id);
        public abstract Task<T> SelectByIdAsync(object id);
        public abstract Task<ProcessingStatus> ValidationBeforeInsertOrUpdateAsync(T value);
    }
}
