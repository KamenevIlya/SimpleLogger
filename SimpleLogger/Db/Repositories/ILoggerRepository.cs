using SimpleLogger.Models;

namespace SimpleLogger.Db.Repositories
{
    /// <summary>
    /// Операции с логами.
    /// </summary>
    public interface ILoggerRepository
    {
        /// <summary>
        /// Записать лог.
        /// </summary>
        /// <param name="message"> Сообщение. </param>
        /// <param name="logType"> Тип лога. </param>
        void WriteLog(string message, LogType logType);

        /// <summary>
        /// Получить последних <see cref="numberOfLogs"/> логов.
        /// </summary>
        /// <param name="numberOfLogs"> Количество логов. </param>
        /// <returns> Список логов. </returns>
        List<Log> GetLastLogs(int numberOfLogs);

        /// <summary>
        /// Получить лог по Id.
        /// </summary>
        /// <param name="id"> Id лога. </param>
        /// <returns> Лог или пустой объект. </returns>
        Log GetLogById(Guid id);
    }
}
