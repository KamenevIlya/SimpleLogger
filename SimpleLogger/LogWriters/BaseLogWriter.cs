using SimpleLogger.Logger;

namespace SimpleLogger.LogWriters
{
    /// <summary>
    /// Базовый класс записывания логов.
    /// </summary>
    public abstract class BaseLogWriter : ILogWriter
    {
        /// <summary>
        /// Логировщик.
        /// </summary>
        public ILogger Logger { get; set; }

        /// <summary>
        /// Конструктор с параметром.
        /// </summary>
        /// <param name="logger"> Логировщик. </param>
        protected BaseLogWriter(ILogger logger)
        {
            Logger = logger;
        }

        /// <summary>
        /// Записать лог.
        /// </summary>
        /// <param name="message"> Сообщение. </param>
        public abstract void WriteLog(string message);
    }
}
