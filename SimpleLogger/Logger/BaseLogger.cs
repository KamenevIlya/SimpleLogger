using SimpleLogger.Models;

namespace SimpleLogger.Logger
{
    /// <summary>
    /// Базовый класс логирования.
    /// </summary>
    public abstract class BaseLogger : ILogger
    {
        /// <summary>
        /// Создать лог.
        /// </summary>
        /// <param name="message"> Сообщение. </param>
        /// <returns> Созданный лог. </returns>
        public abstract Log MakeLog(string message);
    }
}
