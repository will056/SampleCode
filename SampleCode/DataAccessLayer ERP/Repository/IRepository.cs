using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.DataAccessLayer_ERP.Repository
{
    /// <summary>
    /// Интерфейс всех репозиториев (sql и  EF)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T>
    {
        void Delete(object id);
        Task DeleteAsync(object id);
        void Dispose();
        object Insert(T value);
        /// <summary>
        /// Если по id запись не найдена - вставка
        /// При существовании - обновление
        /// </summary>
        /// <param name="value"></param>
        /// <param name="Id"></param>
        /// <returns>id Вставленной записи</returns>
        object InsertOrUpdate(T value, object id);
        List<T> SelectAll();
        T SelectById(object id);
        Task<T> SelectByIdAsync(object id);
        object Update(T value);
    }
}
