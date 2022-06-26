using SimpleLogger.Db.Repositories;
using SimpleLogger.Models;

namespace SimpleLogger.Db
{
    /// <summary>
    /// Провайдер бд логов. 
    /// </summary>
    public class LoggerDataProvider : ILoggerRepository
    {
        private readonly DataContext _dataContext;

        /// <summary>
        /// Конструктор с параметром.
        /// </summary>
        /// <param name="dataContext"> Контекст бд. </param>
        public LoggerDataProvider(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        /// <summary>
        /// Записать лог.
        /// </summary>
        /// <param name="message"> Сообщение. </param>
        /// <param name="logType"> Тип лога. </param>
        public void WriteLog(string message, LogType logType)
        {
            var record = new Log
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                Message = message,
                LogType = logType
            };
            _dataContext.Logs.Add(record);
            _dataContext.SaveChanges();
        }

        /// <summary>
        /// Получить последних <see cref="numberOfLogs"/> логов.
        /// </summary>
        /// <param name="numberOfLogs"> Количество логов. </param>
        /// <returns> Список логов. </returns>
        public List<Log> GetLastLogs(int numberOfLogs)
        {
            return _dataContext.Logs.TakeLast(numberOfLogs).ToList();
        }

        /// <summary>
        /// Получить лог по Id.
        /// </summary>
        /// <param name="id"> Id лога. </param>
        /// <returns> Лог или пустой объект. </returns>
        public Log GetLogById(Guid id)
        {
            return _dataContext.Logs.FirstOrDefault(r => r.Id == id) ?? new Log();
        }
    }
}
