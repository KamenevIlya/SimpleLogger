using SimpleLogger.Models;

namespace SimpleLogger.Logger
{
    /// <summary>
    /// Логирование отладчика.
    /// </summary>
    public class DebugLogger : BaseLogger, ILogger
    {
        /// <summary>
        /// Создать лог.
        /// </summary>
        /// <param name="message"> Сообщение. </param>
        /// <returns> Созданный лог. </returns>
        public override Log MakeLog(string message)
        {
            return new Log
            {
                CreatedAt = DateTime.Now,
                Message = message,
                LogType = LogType.Debug
            };
        }
    }
}
