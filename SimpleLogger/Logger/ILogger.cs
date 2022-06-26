using SimpleLogger.Models;

namespace SimpleLogger.Logger
{
    /// <summary>
    /// Логирование.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Создать лог.
        /// </summary>
        /// <param name="message"> Сообщение. </param>
        /// <returns> Созданный лог. </returns>
        Log MakeLog(string message);
    }
}
