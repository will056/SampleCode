using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleCode.Примеры_кода_из_ERP_на_MVC5.Коллекция_стратегий
{
    /// <summary>
    /// Интерфейс с общими методами всех контекстов
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IStrategyCore<T>
    {
        //Передаю id для универсальности. Что бы не реализовывать метод в каждом sql репозитории 
        object InsertOrUpdate(T value, object id);

        Task<T> SelectByIdAsync(object id);

        Task DeleteAsync(object id);

        //Task<ProcessingStatus> ValidationBeforeInsertOrUpdateAsync(T value);
    }
}
